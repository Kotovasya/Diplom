using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.FileTransfer
{
    [DataContract]
    public class DownloadPartFileRequest : Request
    {
        [DataMember]
        public Guid FileId { get; set; }

        [DataMember]
        public int Offset { get; set; }

        [DataMember]
        public int Size { get; set; }

        public DownloadPartFileRequest(Guid id, Guid fileId, int offset, int size) : base(id)
        {
            FileId = fileId;
            Offset = offset;
            Size = size;
        }
    }
}
