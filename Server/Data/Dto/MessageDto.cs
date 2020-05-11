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
        public string Sender { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public Guid? FileId { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public int? FileSize { get; set; }

        public MessageDto(long id, string sender, string text, Guid? fileId, string fileName, int fileSize)
        {
            Id = id;
            Sender = sender;
            Text = text;
            FileId = fileId;
            FileName = fileName;
            FileSize = fileSize;
        }
    }
}
