using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Server.Data.Dto;

namespace Server.Events.Dialogs
{
    [DataContract]
    public class UserLeavesFromDialogEventArgs : ServerEventArgs
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public UserDto User { get; set; }

        public UserLeavesFromDialogEventArgs(Guid id, int dialogId, UserDto user)
            : base(id)
        {
            DialogId = dialogId;
            User = user;
        }
    }
}
