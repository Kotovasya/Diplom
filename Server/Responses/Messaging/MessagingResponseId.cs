using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Messaging
{
    [DataContract]
    public enum MessagingResponseId
    {
        [EnumMember]
        Successfully = 1,

        [EnumMember]
        ServerException = 16
    }
}
