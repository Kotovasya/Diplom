using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data.Dto
{
    [DataContract]
    public class DialogDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        public DialogDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
