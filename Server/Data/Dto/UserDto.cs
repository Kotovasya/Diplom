using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data.Dto
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public Guid? Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        public UserDto(Guid? id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
