using Engine.Requests.Authorization;
using Engine.Responses.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Server.Controllers
{
    public class AuthorizationController
    {
        public RegistrationResponse RegisterUser(RegistrationRequest request)
        {
            Console.WriteLine("Пользователь {0} зарегистрирован (подключение № {1})", request.Login, request.Id);
            return new RegistrationResponse(ResponseId.Succesfully, request.Id);
        }

        public AuthorizationResponse AuthorizationUser(AuthorizationRequest request)
        {
            Console.WriteLine("Пользователь {0} авторизовался (подключение № {1})", request.Login, request.Id);
            return new AuthorizationResponse(ResponseId.Succesfully, Guid.NewGuid());
        }
    }
}
