using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Requests.Authorization
{
    [DataContract]
    public class RegistrationRequest : Request
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }

        public RegistrationRequest(Guid id, string login, string password)
            : base(id)
        {
            Login = login;
            Password = password;
        }
    }
}
