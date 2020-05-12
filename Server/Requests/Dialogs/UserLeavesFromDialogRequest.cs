using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Server.Data.Dto;

namespace Server.Requests.Dialogs
{
    [DataContract]
    public class UserLeavesFromDialogRequest : Request
    {
        [DataMember]
        public int DialogId { get; set; }

        public UserLeavesFromDialogRequest(Guid id, int dialogId)
            : base(id)
        {
            DialogId = dialogId;
        }
    }
}
