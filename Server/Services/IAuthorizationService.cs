using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Server.Requests.Authorization;
using Server.Responses.Authorization;
using Server.Events.Authorization;

namespace Server.Services
{
    [ServiceContract(CallbackContract = typeof(IAuthorizationServiceCallback))]
    public interface IAuthorizationService
    {
        [OperationContract]
        RegistrationResponse Registration(RegistrationRequest request);

        [OperationContract]
        AuthorizationResponse Authorization(AuthorizationRequest request);

        [OperationContract]
        Guid Connect();
    }

    public interface IAuthorizationServiceCallback
    {
        [OperationContract]
        void OnUserRegistered(UserRegisteredEventArgs args);

        [OperationContract]
        void OnUserLogined(UserLoginedEventArgs args);

        [OperationContract]
        void BlaBlac();
    }
}
