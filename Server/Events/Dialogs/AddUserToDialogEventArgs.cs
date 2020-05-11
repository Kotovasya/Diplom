using Server.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Events.Dialogs
{
    [DataContract]
    public class AddUserToDialogEventArgs : ServerEventArgs
    {
        [DataMember]
        public UserDto User { get; set; }

        public AddUserToDialogEventArgs(Guid id, UserDto user) : base(id)
        {
            User = user;
        }
    }
}
