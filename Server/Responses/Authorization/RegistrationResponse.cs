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
        public AuthorizationResponseId Result { get; set; }
        [DataMember]
        public Guid Id { get; set; }

        public RegistrationResponse(AuthorizationResponseId result, Guid id)
        {
            Result = result;
            Id = id;
        }
    }
}
