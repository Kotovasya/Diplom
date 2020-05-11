using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data.Dto
{
    [DataContract]
    public class FileDto
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public byte[] Data { get; set; }

        public FileDto(string name, byte[] data)
        {
            Name = name;
            Data = data;
        }
    }
}
