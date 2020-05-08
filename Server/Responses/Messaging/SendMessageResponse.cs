using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Messaging
{
    [DataContract]
    public class SendMessageResponse
    {
        [DataMember]
        public MessagingResponseId Result { get; set; }

        public SendMessageResponse(MessagingResponseId result)
        {
            Result = result;
        }
    }
}
