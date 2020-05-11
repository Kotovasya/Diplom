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
    public class EditDialogResponse
    {
        [DataMember]
        public DialogResponseId Result { get; set; }

        public DialogDto Dialog { get; set; }

        public EditDialogResponse(DialogResponseId result)
        {
            Result = result;
        }

        public EditDialogResponse(DialogResponseId result, DialogDto dialog)
        {
            Result = result;
            Dialog = dialog;
        }
    }
}
