using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Server.Requests.Authorization;
using Server.Responses.Authorization;

namespace Server.Services
{
    [ServiceContract]
    public interface IAuthorizationService
    {
        [OperationContract]
        RegistrationResponse Registration(RegistrationRequest request);

        [OperationContract]
        AuthorizationResponse Authorization(AuthorizationRequest request);

        [OperationContract]
        Guid Connect();
    }
}
