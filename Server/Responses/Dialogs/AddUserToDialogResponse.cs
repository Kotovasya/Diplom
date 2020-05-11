using Server.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Dialogs
{
    [DataContract]
    public class AddUserToDialogResponse
    {
        [DataMember]
        public DialogResponseId Result { get; set; }

        public UserDto User { get; set; }

        public AddUserToDialogResponse(DialogResponseId result)
        {
            Result = result;
        }

        public AddUserToDialogResponse(DialogResponseId result, UserDto user)
        {
            Result = result;
            User = user;
        }
    }
}
