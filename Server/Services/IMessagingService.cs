using Server.Events.Messaging;
using Server.Requests.Messaging;
using Server.Responses.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    [ServiceContract (CallbackContract = typeof(IMessagingServiceCallback))]
    public interface IMessagingService
    {
        [OperationContract]
        SendMessageResponse SendMessage(SendMessageRequest request);
    }

    public interface IMessagingServiceCallback
    {
        [OperationContract (IsOneWay = true)]
        void OnSendedMessage(SendedMessageEventArgs args);
    }
}
