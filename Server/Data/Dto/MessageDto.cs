using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data.Dto
{
    [DataContract]
    public class MessageDto
    {
        [DataMember]
        public long Id { get; set; }
        
        [DataMember]
        public UserDto Sender { get; set; }

        [DataMember]
        public DialogDto Dialog { get; set; }

        [DataMember]
        public FileDto File { get; set; }

        [DataMember]
        public string Text { get; set; }

        public MessageDto(long id, UserDto sender, DialogDto dialog, FileDto file, string text)
        {
            Id = id;
            Sender = sender;
            Dialog = dialog;
            File = file;
            Text = text;
        }
    }
}
