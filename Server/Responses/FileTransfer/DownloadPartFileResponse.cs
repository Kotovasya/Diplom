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
    public class DownloadPartFileResponse
    {
        [DataMember]
        public FileTransferResponseId Result { get; set; }

        [DataMember]
        public byte[] Data { get; set; }

        public DownloadPartFileResponse(FileTransferResponseId result)
        {
            Result = result;
        }

        public DownloadPartFileResponse(FileTransferResponseId result, byte[] data)
        {
            Result = result;
            Data = data;
        }
    }
}
