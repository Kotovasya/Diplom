using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Dialogs
{
    [DataContract]
    public class DeleteDialogResponse
    {
        [DataMember]
        public DialogResponseId Result { get; set; }

        public DeleteDialogResponse(DialogResponseId result)
        {
            Result = result;
        }
    }
}
