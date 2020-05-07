using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Requests
{
    [DataContract(Namespace = "http://Server")]
    public abstract class Request
    {
        [DataMember]
        public Guid Id { get; set; }

        public Request(Guid id)
        {
            Id = id;
        }
    }
}
