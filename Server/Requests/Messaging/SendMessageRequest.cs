using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.Messaging
{
    [DataContract]
    public class SendMessageRequest : Request
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public Guid? FileId { get; set; }

        public SendMessageRequest(Guid id, int dialogId, string text)
            : base(id)
        {
            Id = id;
            DialogId = dialogId;
            Text = text;
            FileId = null;
        }

        public SendMessageRequest(Guid id, int dialogId, string text, Guid fileId)
            : base(id)
        {
            Id = id;
            DialogId = dialogId;
            Text = text;
            FileId = fileId;
        }
    }
}
