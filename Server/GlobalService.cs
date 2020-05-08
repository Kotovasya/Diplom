using Server.Requests.Authorization;
using Server.Responses.Authorization;
using Server.Services;
using Server.Events.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Server.Events;
using System.Reflection;
using Server.Responses.Messaging;
using Server.Requests.Messaging;
using Server.Events.Messaging;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, //единая сессия для всех пользователей
        IncludeExceptionDetailInFaults = false)] 
    public class GlobalService : IGlobalService
    {
        private readonly ServerModel Model;

        private readonly Dictionary<Guid, ServerUser> Connections;

        public GlobalService()
        {
            Model = new ServerModel();
            Connections = new Dictionary<Guid, ServerUser>();
        }

        #region Authorization Service

        public Guid Connect()
        {
            ConnectionId connection = new ConnectionId(Guid.NewGuid(), true);
            try
            {
                Connections.Add(connection.Id, null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return connection.Id;
        }

        public AuthorizationResponse Authorization(AuthorizationRequest request)
        {
            AuthorizationResponse response = Model.Authorization.AuthorizationUser(request);
            if (response.Result != AuthorizationResponseId.Successfully)
                return response;

            Connections.Remove(request.Id);
            Connections.Add(response.Id, new ServerUser(new ConnectionId(response.Id), request.Login, OperationContext.Current));

            UserLoginedEventArgs args = new UserLoginedEventArgs(response.Id, request.Login);
            SendBroadcastMessage<UserLoginedEventArgs>("IAuthorizationServiceCallback", "OnUserLogined", args);

            return response;
        }

        public RegistrationResponse Registration(RegistrationRequest request)
        {
            RegistrationResponse response = Model.Authorization.RegisterUser(request);
            if (response.Result != AuthorizationResponseId.Successfully)
                return response;

            Connections.Remove(request.Id);
            Connections.Add(response.Id, new ServerUser(new ConnectionId(response.Id), request.Login, OperationContext.Current));

            UserRegisteredEventArgs args = new UserRegisteredEventArgs(response.Id, request.Login);
            SendBroadcastMessage<UserRegisteredEventArgs>("IAuthorizationServiceCallback", "OnUserRegistered", args);

            return response;
        }

        #endregion

        #region Messaging Service
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            SendMessageResponse response = Model.Messaging.SendMessage(request);
            if (response.Result != MessagingResponseId.Successfully)
                return response;

            SendedMessageEventArgs args = new SendedMessageEventArgs(request.Id, Connections[request.Id].Login, request.Text);
            Console.WriteLine("Пользователь {0} отправил сообщение: {1}", args.Sender, args.Text);
            SendBroadcastMessage<SendedMessageEventArgs>("IMessagingServiceCallback", "OnSendedMessage", args);

            return response;
        }
        #endregion

        public void SendBroadcastMessage<TEvent>(string interfaceName, string methodName, TEvent args)
            where TEvent : ServerEventArgs
        {
            foreach (var connection in Connections)
            {
                if (connection.Key != args.Id && !connection.Value.Connection.IsTemporary)
                {
                    IGlobalServiceCallback service = connection.Value.OperationContext.GetCallbackChannel<IGlobalServiceCallback>();
                    MethodInfo m = service.GetType().GetInterface(interfaceName).GetMethod(methodName);
                    m.Invoke(service, new object[] { args });
                }
            }
        }
    }
}
