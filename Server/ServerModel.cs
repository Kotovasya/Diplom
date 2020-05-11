using Server.Controllers;
using Server.Data;
using Server.Events;
using Server.Events.Authorization;
using Server.Services;
using System;
using System.Collections.Generic;

namespace Server
{
    public class ServerModel
    {
        public DatabaseContext Database { get; private set; }
        public AuthorizationController Authorization { get; private set; }
        public MessagingController Messaging { get; private set; }
        public FileTransferController FileTransfer { get; private set; }

        public ServerModel()
        {
            Database = new DatabaseContext();
            Authorization = new AuthorizationController(Database);
            Messaging = new MessagingController(Database);
            FileTransfer = new FileTransferController(Database);
        }
    }
}