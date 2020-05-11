using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.Dialogs
{
    [DataContract]
    public class DeleteDialogRequest : Request
    {
        [DataMember]
        public int DialogId { get; set; }

        public DeleteDialogRequest(Guid id, int dialogId) : base(id)
        {
            DialogId = dialogId;
        }
    }
}
