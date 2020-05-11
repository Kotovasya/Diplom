using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Events.Dialogs
{
    [DataContract]
    public class DeleteDialogEventArgs : ServerEventArgs
    {
        [DataMember]
        public int DialogId { get; set; }

        public DeleteDialogEventArgs(Guid userId, int dialogId)
            : base(userId)
        {
            DialogId = dialogId;
        }
    }
}
