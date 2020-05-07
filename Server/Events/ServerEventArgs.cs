using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Events
{
    [DataContract]
    public class ServerEventArgs : EventArgs
    {
        [DataMember]
        public Guid Id { get; set; }

        public ServerEventArgs(Guid id)
        {
            Id = id;
        }
    }
}
