using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Events.Authorization
{
    [DataContract]
    public class UserLoginedEventArgs : ServerEventArgs
    {
        [DataMember]
        public string Login { get; set; }

        public UserLoginedEventArgs(Guid id, string login)
            : base(id)
        {
            Login = login;
        }
    }
}
