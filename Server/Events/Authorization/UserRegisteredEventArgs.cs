using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Events.Authorization
{
    [DataContract]
    public class UserRegisteredEventArgs : ServerEventArgs
    {
        [DataMember]
        public string Login { get; set; }

        public UserRegisteredEventArgs(Guid id, string login)
            : base(id)
        {
            Id = id;
            Login = login;
        }
    }
}
