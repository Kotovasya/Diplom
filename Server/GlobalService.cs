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
using Server.Responses.FileTransfer;
using Server.Requests.FileTransfer;
using Server.Responses.Dialogs;
using Server.Requests.Dialogs;
using Server.Events.Dialogs;

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
            SendOtherUsersEvent<UserLoginedEventArgs>("IAuthorizationServiceCallback", "OnUserLogined", args);

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
            SendOtherUsersEvent<UserRegisteredEventArgs>("IAuthorizationServiceCallback", "OnUserRegistered", args);

            return response;
        }

        #endregion

        #region Messaging Service
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            SendMessageResponse response = Model.Messaging.SendMessage(request);
            if (response.Result != MessagingResponseId.Successfully)
                return response;

            SendedMessageEventArgs args = new SendedMessageEventArgs(request.Id, request.DialogId, response.Message);
            Console.WriteLine("Пользователь GUID {0} отправил сообщение в диалог ID {1}", request.Id, request.DialogId);
            SendOtherUsersEvent<SendedMessageEventArgs>("IMessagingServiceCallback", "OnSendedMessage", args);

            return response;
        }
        #endregion

        #region File Service
        public UploadFileResponse UploadFile(UploadFileRequest request)
        {
            UploadFileResponse response = Model.FileTransfer.UploadFile(request);
            return response;
        }

        public UploadPartFileResponse UploadPartFile(UploadPartFileRequest request)
        {
            UploadPartFileResponse response = Model.FileTransfer.UploadPartFile(request);
            return response;
        }

        public DownloadPartFileResponse DownloadPartFile(DownloadPartFileRequest request)
        {
            DownloadPartFileResponse response = Model.FileTransfer.DownloadPartFile(request);
            return response;
        }
        #endregion

        #region Dialog Service
        public CreateDialogResponse CreateDialog(CreateDialogRequest request)
        {
            CreateDialogResponse response = Model.DialogController.CreateDialog(request);
            if (response.Result != DialogResponseId.Successfully)
                return response;

            CreateDialogEventArgs args = new CreateDialogEventArgs(request.Id, response.Dialog);
            Console.WriteLine("Пользователь (GUID {0}) создал диалог {1}", request.Id, request.Name);
            SendOtherUsersEvent<CreateDialogEventArgs>("IDialogServiceCallback", "OnCreatedDialog", args);

            return response;
        }

        public EditDialogResponse EditDialog(EditDialogRequest request)
        {
            EditDialogResponse response = Model.DialogController.EditDialog(request);
            if (response.Result != DialogResponseId.Successfully)
                return response;

            EditDialogEventArgs args = new EditDialogEventArgs(request.Id, request.DialogId, request.EditedName);
            Console.WriteLine("Пользователь (GUID {0}) сменил название диалога ID {1} на {2}", request.Id, request.DialogId, request.EditedName);
            SendOtherUsersEvent<EditDialogEventArgs>("IDialogServiceCallback", "OnEditedDialog", args);

            return response;
        }

        public DeleteDialogResponse DeleteDialog(DeleteDialogRequest request)
        {
            DeleteDialogResponse response = Model.DialogController.DeleteDialog(request);
            if (response.Result != DialogResponseId.Successfully)
                return response;

            DeleteDialogEventArgs args = new DeleteDialogEventArgs(request.Id, request.DialogId);
            Console.WriteLine("Пользователь (GUID {0}) удалил диалог ID {1}", request.Id, request.DialogId);
            SendOtherUsersEvent<DeleteDialogEventArgs>("IDialogServiceCallback", "OnDeletedDialog", args);

            return response;
        }

        public AddUserToDialogResponse AddUserToDialog(AddUserToDialogRequest request)
        {
            AddUserToDialogResponse response = Model.DialogController.AddUserToDialog(request);
            if (response.Result != DialogResponseId.Successfully)
                return response;

            AddUserToDialogEventArgs args = new AddUserToDialogEventArgs(request.Id, request.DialogId, response.User);
            Console.WriteLine("Пользователь (GUID {0}) добавил пользователя (GUID {1}) в диалог ID {2}", request.Id, request.UserId, request.DialogId);
            SendOtherUsersEvent<AddUserToDialogEventArgs>("IDialogServiceCallback", "OnUserAdded", args);

            return response;
        }

        public JoinToDialogResponse JoinToDialog(JoinToDialogRequest request)
        {
            JoinToDialogResponse response = Model.DialogController.JoinToDialog(request);
            if (response.Result != DialogResponseId.Successfully)
                return response;

            UserJoinedToDialogEventArgs args = new UserJoinedToDialogEventArgs(request.Id, response.User);
            Console.WriteLine("Пользователь (GUID {0}) вошел в диалог ID {1}", request.Id, request.DialogId);
            SendOtherUsersEvent<UserJoinedToDialogEventArgs>("IDialogServiceCallback", "OnUserJoined", args);

            return response;
        }

        public UserLeavesFromDialogResponse LeaveFromDialog(UserLeavesFromDialogRequest request)
        {
            UserLeavesFromDialogResponse response = Model.DialogController.LeaveFromDialog(request);
            if (response.Result != DialogResponseId.Successfully)
                return response;

            UserLeavesFromDialogEventArgs args = new UserLeavesFromDialogEventArgs(request.Id, request.DialogId, response.User);
            Console.WriteLine("Пользователь (GUID {0}) вышел из диалога ID {1}", request.Id, request.DialogId);
            SendOtherUsersEvent<UserLeavesFromDialogEventArgs>("IDialogServiceCallback", "OnUserLeaves", args);

            return response;
        }
        #endregion

        public void SendAllEvent<TEvent>(string interfaceName, string methodName, TEvent args, bool isSendTemporary = false)
            where TEvent : ServerEventArgs
        {
            foreach(var connection in Connections)
            {
                if (isSendTemporary || !connection.Value.Connection.IsTemporary)
                {
                    IGlobalServiceCallback service = connection.Value.OperationContext.GetCallbackChannel<IGlobalServiceCallback>();
                    MethodInfo m = service.GetType().GetInterface(interfaceName).GetMethod(methodName);
                    m.Invoke(service, new object[] { args });
                }
            }
        }

        public void SendOtherUsersEvent<TEvent>(string interfaceName, string methodName, TEvent args, bool isSendTemporary = false)
            where TEvent : ServerEventArgs
        {
            foreach (var connection in Connections)
            {
                if (connection.Key != args.Id && (isSendTemporary || !connection.Value.Connection.IsTemporary))
                {
                    IGlobalServiceCallback service = connection.Value.OperationContext.GetCallbackChannel<IGlobalServiceCallback>();
                    MethodInfo m = service.GetType().GetInterface(interfaceName).GetMethod(methodName);
                    m.Invoke(service, new object[] { args });
                }
            }
        }

        public void SendSpecificUsersEvent<TEvent>(Guid[] users, string interfaceName, string methodName, TEvent args, bool isSendTemporary = false)
            where TEvent : ServerEventArgs
        {
            foreach (var connection in Connections)
            {
                if (users.Contains(connection.Key) && (isSendTemporary || !connection.Value.Connection.IsTemporary))
                {
                    IGlobalServiceCallback service = connection.Value.OperationContext.GetCallbackChannel<IGlobalServiceCallback>();
                    MethodInfo m = service.GetType().GetInterface(interfaceName).GetMethod(methodName);
                    m.Invoke(service, new object[] { args });
                }
            }
        }
    }
}
