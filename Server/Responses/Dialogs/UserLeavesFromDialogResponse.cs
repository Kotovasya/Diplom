using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Server.Data.Dto;

namespace Server.Responses.Dialogs
{
    [DataContract]
    public class UserLeavesFromDialogResponse
    {
        [DataMember]
        public DialogResponseId Result { get; set; }

        public UserDto User { get; set; }

        public UserLeavesFromDialogResponse(DialogResponseId result)
        {
            Result = result;
        }

        public UserLeavesFromDialogResponse(DialogResponseId result, UserDto user)
        {
            Result = result;
            User = user;
        }
    }
}
