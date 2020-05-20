using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Dialog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<User> Users { get; set; }
        public HashSet<Message> Messages { get; set; }

        public Dialog(int id, string name)
        {
            Users = new HashSet<User>();
            Messages = new HashSet<Message>();
        }

        public Dialog(DialogDto dialog)
            : this(dialog.Id, dialog.Name)
        {
        }
    }
}
