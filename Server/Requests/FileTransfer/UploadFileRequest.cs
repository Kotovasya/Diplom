using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.FileTransfer
{
    [DataContract]
    public class UploadFileRequest : Request
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public byte[] Data { get; set; }

        public UploadFileRequest(Guid id, string name, byte[] data)
            : base(id)
        {
            Name = name;
            Data = data;
        }
    }
}
