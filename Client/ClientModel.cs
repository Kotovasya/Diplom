using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IO;

namespace Client
{
    public class ClientModel : IGlobalServiceCallback
    {
        public class ConnectedEventArgs : EventArgs
        {
            public bool Successfully { get; private set; }
            public Exception Exception { get; private set; }

            public ConnectedEventArgs(bool result, Exception exception = null)
            {
                Successfully = result;
            }
        }

        public Guid Id { get; set; }
        public GlobalServiceClient Service { get; private set; }

        public EventHandler<ConnectedEventArgs> Connected;

        public EventHandler<SendedMessageEventArgs> MessageReceived;
        public EventHandler<UserLoginedEventArgs> UserLogined;
        public EventHandler<UserRegisteredEventArgs> UserRegistered;
        public EventHandler<CreateDialogEventArgs> DialogCreated;
        public EventHandler<EditDialogEventArgs> DialogEdited;
        public EventHandler<DeleteDialogEventArgs> DialogDeleted;
        public EventHandler<UserJoinedToDialogEventArgs> UserJoinedToDialog;
        public EventHandler<AddUserToDialogEventArgs> UserAddedToDialog;
        public EventHandler<UserLeavesFromDialogEventArgs> UserLeavesFromDialog;

        public ClientModel()
        {
            Service = new GlobalServiceClient(new InstanceContext(this));
            try 
            {
                Id = Service.Connect();
                Connected?.Invoke(this, new ConnectedEventArgs(true));
            }
            catch (Exception e)
            {
                Connected?.Invoke(this, new ConnectedEventArgs(false, e));
            }
        }

        public void OnSendedMessage(SendedMessageEventArgs args)
        {
            MessageReceived?.Invoke(this, args);
        }

        public void OnUserLogined(UserLoginedEventArgs args)
        {
            UserLogined?.Invoke(this, args);
        }

        public void OnUserRegistered(UserRegisteredEventArgs args)
        {
            UserRegistered?.Invoke(this, args);
        }

        public void OnCreatedDialog(CreateDialogEventArgs args)
        {
            DialogCreated?.Invoke(this, args);
        }

        public void OnDeletedDialog(DeleteDialogEventArgs args)
        {
            DialogDeleted?.Invoke(this, args);
        }

        public void OnEditedDialog(EditDialogEventArgs args)
        {
            DialogEdited?.Invoke(this, args);
        }

        public void OnUserAdded(AddUserToDialogEventArgs args)
        {
            UserAddedToDialog?.Invoke(this, args);
        }

        public void OnUserJoined(UserJoinedToDialogEventArgs args)
        {
            UserJoinedToDialog?.Invoke(this, args);
        }

        public void OnUserLeaves(UserLeavesFromDialogEventArgs args)
        {
            UserLeavesFromDialog?.Invoke(this, args);
        }

        public async Task<Guid?> UploadFile(FileStream stream)
        {
            byte[] data = new byte[1024];
            int size = await stream.ReadAsync(data, 0, 1024);
            int offset = 1024;
            UploadFileRequest firstRequest = new UploadFileRequest() { Id = Id, Name = stream.Name, Size = size, Data = data};
            UploadFileResponse firstResponse = await Service.UploadFileAsync(firstRequest);
            if (firstResponse.Result == FileTransferResponseId.Successfully)
            {
                do
                {
                    await stream.ReadAsync(data, offset, 1024);
                    UploadPartFileRequest request = new UploadPartFileRequest() { Id = Id, FileId = firstResponse.FileId, Data = data, Offset = offset };
                    UploadPartFileResponse response = await Service.UploadPartFileAsync(request);
                    if (response.Result != FileTransferResponseId.Successfully)
                        return null;
                    if (offset == (int)stream.Length)
                        break;
                    offset += 1024;
                    if (offset > stream.Length)
                        offset = (int)stream.Length;
                } while (true);
                return firstResponse.FileId;
            }
            else
                return null;
        }
    }
}
