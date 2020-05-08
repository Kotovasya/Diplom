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
        public string Sender { get; set; }

        [DataMember]
        public string Text { get; set; }

        public SendedMessageEventArgs(Guid id, string sender, string text)
            : base(id)
        {
            Sender = sender;
            Text = text;
        }
    }
}
