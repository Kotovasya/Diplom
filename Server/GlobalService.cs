using Server.Models;
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

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, //единая сессия для всех пользователей
        IncludeExceptionDetailInFaults = true)] 
    public class GlobalService : IAuthorizationService
    {
        private readonly ServerModel Model;

        private readonly Dictionary<Guid, ServerUser> Connections;

        public GlobalService()
        {
            Model = new ServerModel();
            Connections = new Dictionary<Guid, ServerUser>();
        }

        public Guid Connect()
        {
            ConnectionId connection = new ConnectionId(Guid.NewGuid(), true);
            try
            {
                Connections.Add(connection.Id, new ServerUser(connection, OperationContext.Current));
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
            if (response.Result != ResponseId.Succesfully)
                return response;

            Connections.Remove(request.Id);
            Connections.Add(response.Id, new ServerUser(new ConnectionId(response.Id), OperationContext.Current));

            UserLoginedEventArgs args = new UserLoginedEventArgs(response.Id, request.Login);
            SendBroadcastMessage<IAuthorizationServiceCallback, UserLoginedEventArgs>("OnUserLogined", args, null);

            return response;
        }

        public RegistrationResponse Registration(RegistrationRequest request)
        {
            RegistrationResponse response = Model.Authorization.RegisterUser(request);
            if (response.Result != ResponseId.Succesfully)
                return response;

            Connections.Remove(request.Id);
            Connections.Add(response.Id, new ServerUser(new ConnectionId(response.Id), OperationContext.Current));

            UserRegisteredEventArgs args = new UserRegisteredEventArgs(response.Id, request.Login);
            SendBroadcastMessage<IAuthorizationServiceCallback, UserRegisteredEventArgs>("OnUserRegistered", args, null);

            return response;
        }

        public void SendBroadcastMessage<TInterface, TEvent>(string methodName, TEvent args, TInterface service)
            where TEvent : ServerEventArgs
        {
            foreach (var connection in Connections)
            {
                if (connection.Key != args.Id)
                {
                    service = connection.Value.OperationContext.GetCallbackChannel<TInterface>();
                    MethodInfo m = service.GetType().GetMethod(methodName);
                    m.Invoke(service, new object[] { args });
                }
            }
        }
    }
}
