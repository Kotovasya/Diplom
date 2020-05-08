using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

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

        public Guid Id { get; private set; }
        public GlobalServiceClient Service { get; private set; }

        public EventHandler<ConnectedEventArgs> Connected;

        public EventHandler<SendedMessageEventArgs> MessageReceived;
        public EventHandler<UserLoginedEventArgs> UserLogined;
        public EventHandler<UserRegisteredEventArgs> UserRegistered;

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
    }
}
