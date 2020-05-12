using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Dialogs
{
    [DataContract]
    public enum DialogResponseId
    {
        [EnumMember]
        Successfully = 1,

        [EnumMember]
        DialogNotExist = 2,

        [EnumMember]
        UserAlreadyInDialog = 4,

        [EnumMember]
        UserNotExist = 8,

        [EnumMember]
        ServerException = 16,
    }
}
