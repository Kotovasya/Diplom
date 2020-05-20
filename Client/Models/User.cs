using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public User(UserDto user)
            : this(user.Id, user.Name)
        {
        }
    }
}
