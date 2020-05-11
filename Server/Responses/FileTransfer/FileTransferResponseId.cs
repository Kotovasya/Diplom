using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.FileTransfer
{
    [DataContract]
    public enum FileTransferResponseId
    {
        [EnumMember]
        Successfully = 1,

        [EnumMember]
        FileNotExist = 2,

        [EnumMember]
        ServerException = 16,
    }
}
