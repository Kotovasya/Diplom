using Server.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Events.Messaging
{
    [DataContract]
    public class SendedMessageEventArgs : ServerEventArgs
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public MessageDto Message { get; set; }

        public SendedMessageEventArgs(Guid id, int dialogId, MessageDto message)
            : base(id)
        {
            DialogId = dialogId;
            Message = message;
        }
    }
}
