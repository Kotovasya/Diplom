using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    [ServiceContract (CallbackContract = typeof(IMessageServiceCallback))]
    public interface IMessageService
    {

    }

    public interface IMessageServiceCallback
    {

    }
}
