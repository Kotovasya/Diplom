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
        public string Text { get; set; }

        public SendMessageRequest(Guid id, string text)
            : base(id)
        {
            Id = id;
            Text = text;
        }
    }
}
