using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Server.Requests.Authorization
{
    [DataContract]
    public class AuthorizationRequest : Request
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }

        public AuthorizationRequest(Guid id, string login, string password)
            : base(id)
        {
            Login = login;
            Password = password;
        }
    }
}
