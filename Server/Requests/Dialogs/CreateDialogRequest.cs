using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests.Dialogs
{
    [DataContract]
    public class CreateDialogRequest : Request
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Guid[] Users { get; set; }

        public CreateDialogRequest(Guid id, string name, Guid[] users) : base(id)
        {
            Name = name;
            Users = users;
        }
    }
}
