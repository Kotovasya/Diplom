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
    public class CreateDialogResponse
    {
        [DataMember]
        public DialogResponseId Result { get; set; }

        [DataMember]
        public DialogDto Dialog { get; set; }

        public CreateDialogResponse(DialogResponseId result)
        {
            Result = result;
        }

        public CreateDialogResponse(DialogResponseId result, DialogDto dialog)
        {
            Result = result;
            Dialog = dialog;
        }
    }
}
