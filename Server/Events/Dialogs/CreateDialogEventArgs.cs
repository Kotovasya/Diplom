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
    public class CreateDialogEventArgs : ServerEventArgs
    {
        [DataMember]
        public DialogDto Dialog { get; set; }

        public CreateDialogEventArgs(Guid id, DialogDto dialog) : base(id)
        {
            Dialog = dialog;
        }
    }
}
