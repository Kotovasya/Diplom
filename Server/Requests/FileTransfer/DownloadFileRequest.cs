using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.FileTransfer
{
    [DataContract]
    public class DownloadFileRequest : Request
    {
        [DataMember]
        public Guid FileId { get; set; }

        public DownloadFileRequest(Guid id, Guid fileId) : base(id)
        {
            FileId = fileId;
        }
    }
}
