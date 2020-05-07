using Server.Models;
using Server.Requests.Authorization;
using Server.Responses.Authorization;
using Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, //единая сессия для всех пользователей
        IncludeExceptionDetailInFaults = true)] 
    public class GlobalService : IAuthorizationService
    {
        private readonly ServerModel Model;

        private readonly Dictionary<Guid, ServerUser> Connections;

        public GlobalService()
        {
            Model = new ServerModel();
            Connections = new Dictionary<Guid, ServerUser>();
        }

        public Guid Connect()
        {
            ConnectionId connection = new ConnectionId(Guid.NewGuid(), true);
            try
            {
                Connections.Add(connection.Id, new ServerUser(ref connection));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return connection.Id;
        }

        public AuthorizationResponse Authorization(AuthorizationRequest request)
        {
            AuthorizationResponse response = Model.Authorization.AuthorizationUser(request);
            return response;
        }

        public RegistrationResponse Registration(RegistrationRequest request)
        {
            RegistrationResponse response = Model.Authorization.RegisterUser(request);
            return response;
        }
    }
}
