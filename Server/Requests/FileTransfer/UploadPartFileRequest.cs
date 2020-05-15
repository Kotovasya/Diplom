using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.FileTransfer
{
    [DataContract]
    public class UploadPartFileRequest : Request
    {
        [DataMember]
        public Guid FileId { get; set; }

        [DataMember]
        public int Offset { get; set; }

        [DataMember]
        public byte[] Data { get; set; }

        public UploadPartFileRequest(Guid id, Guid fileId, int offset, byte[] data)
            : base(id)
        {
            FileId = fileId;
            Offset = offset;
            Data = data;
        }
    }
}
