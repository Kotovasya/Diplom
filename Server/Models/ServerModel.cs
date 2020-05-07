using Server.Controllers;
using Server.Data;

namespace Server.Models
{
    public class ServerModel
    {
        public DatabaseContext Database { get; private set; }
        public AuthorizationController Authorization { get; private set; }

        public ServerModel()
        {
            Database = new DatabaseContext();
            Authorization = new AuthorizationController(Database);
        }
    }
}