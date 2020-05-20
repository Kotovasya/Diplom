using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Message
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public User Sender { get; set; }

        public File File { get; set; }

        public int DialogId { get; set; }

        public Message(MessageDto message)
        {
            Id = message.Id;
            Text = message.Text;
            Sender = new User(message.Sender);
            File = new File(message.File);
            DialogId = message.Dialog.Id;
        }
    }
}
