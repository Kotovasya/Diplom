using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Authorization
{
    [DataContract]
    public class RegistrationResponse
    {
        [DataMember]
        public ResponseId Result { get; set; }
        [DataMember]
        public Guid Id { get; set; }

        public RegistrationResponse(ResponseId result, Guid id)
        {
            Result = result;
            Id = id;
        }
    }
}
