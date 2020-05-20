using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.Dialogs
{
    [DataContract]
    public class GetMessagesRequest
    {
        [DataMember]
        public Guid DialogId { get; set; }

        [DataMember]
        public int MessageOffset { get; set; }

        [DataMember]
        public int Count { get; set; }

        public GetMessagesRequest(Guid dialogId, int messageOffset, int count)
        {
            DialogId = dialogId;
            MessageOffset = messageOffset;
            Count = count;
        }
    }
}
