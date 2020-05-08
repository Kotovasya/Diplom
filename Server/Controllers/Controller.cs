using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public abstract class Controller
    {
        protected DatabaseContext Context { get; set; }

        protected Controller(DatabaseContext context)
        {
            Context = context;
        }
    }
}
