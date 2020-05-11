using Server.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.FileTransfer
{
    [DataContract]
    public class DownloadFileResponse
    {
        [DataMember]
        public FileTransferResponseId Result { get; set; }

        [DataMember]
        public FileDto File { get; set; }

        public DownloadFileResponse(FileTransferResponseId result)
        {
            Result = result;
        }

        public DownloadFileResponse(FileTransferResponseId result, FileDto file)
        {
            Result = result;
            File = file;
        }
    }
}
