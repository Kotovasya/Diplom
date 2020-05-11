using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Events.Dialogs
{
    [DataContract]
    public class EditDialogEventArgs : ServerEventArgs
    {
        [DataMember]
        public int DialogId { get; set; }

        [DataMember]
        public string EditName { get; set; }

        public EditDialogEventArgs(Guid id, int dialogId, string editName) : base(id)
        {
            DialogId = dialogId;
            EditName = editName;
        }
    }
}
