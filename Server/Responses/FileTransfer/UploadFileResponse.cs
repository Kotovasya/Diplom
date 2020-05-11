using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.FileTransfer
{
    [DataContract]
    public class UploadFileResponse
    {
        [DataMember]
        public FileTransferResponseId Result { get; set; }

        public UploadFileResponse(FileTransferResponseId result)
        {
            Result = result;
        }
    }
}
