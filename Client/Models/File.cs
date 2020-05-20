using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }


        public File(Guid id, string name, int size)
        {
            Id = id;
            Name = name;
            Size = size;
        }

        public File(FileDto file)
            : this(file.Id, file.Name, file.Size)
        {
        }
    }
}
