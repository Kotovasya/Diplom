using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.Dialogs
{
    [DataContract]
    public class EditDialogRequest : Request
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public string EditedName { get; set; }

        public EditDialogRequest(Guid id, Guid dialogId, string newName) : base(id)
        {
            DialogId = dialogId;
            EditedName = newName;
        }
    }
}
