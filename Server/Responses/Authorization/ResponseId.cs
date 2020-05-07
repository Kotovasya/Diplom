using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Authorization
{
    [DataContract]
    public enum ResponseId
    {
        [EnumMember]
        Succesfully = 1,

        [EnumMember]
        AlreadyRegister = 2,

        [EnumMember]
        WrongLogin = 4,
        [EnumMember]
        WrongPassword = 8,

        [EnumMember]
        ServerException = 16,
    }
}
