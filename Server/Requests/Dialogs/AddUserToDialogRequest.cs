using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.Dialogs
{
    [DataContract]
    public class AddUserToDialogRequest : Request
    {
        [DataMember]
        public Guid UserId { get; set; }

        [DataMember]
        public int DialogId { get; set; }

        public AddUserToDialogRequest(Guid id, Guid userId, int dialogId) : base(id)
        {
            UserId = userId;
            DialogId = dialogId;
        }
    }
}
