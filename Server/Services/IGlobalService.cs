using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    [ServiceContract (CallbackContract = typeof(IGlobalServiceCallback))]
    public interface IGlobalService : IAuthorizationService, IMessagingService, IFileTransferService
    {
    }

    [ServiceContract]
    public interface IGlobalServiceCallback : IAuthorizationServiceCallback, IMessagingServiceCallback
    {
    }
}
