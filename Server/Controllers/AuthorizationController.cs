using Server.Data;
using Server.Events.Authorization;
using Server.Requests.Authorization;
using Server.Responses.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class AuthorizationController : Controller
    {
        public AuthorizationController(DatabaseContext context)
            : base(context)
        {
        }

        public RegistrationResponse RegisterUser(RegistrationRequest request)
        {
            try
            {
                if (Context.Users.Any(u => u.Login.ToLower() == request.Login.ToLower()))
                    return new RegistrationResponse(AuthorizationResponseId.AlreadyRegister, request.Id);

                Console.WriteLine("Пользователь {0} зарегистрирован (подключение № {1})", request.Login, request.Id);
                Context.Users.Add(new User(request.Id, request.Login, request.Password));
                Context.SaveChangesAsync();

                return new RegistrationResponse(AuthorizationResponseId.Successfully, request.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new RegistrationResponse(AuthorizationResponseId.ServerException, request.Id);
            }
        }

        public AuthorizationResponse AuthorizationUser(AuthorizationRequest request)
        {
            try
            {
                User authUser = Context.Users.SingleOrDefault(u => u.Login.ToLower() == request.Login.ToLower());
                if (authUser == null)
                    return new AuthorizationResponse(AuthorizationResponseId.WrongLogin, request.Id);

                if (authUser.Password != request.Password)
                    return new AuthorizationResponse(AuthorizationResponseId.WrongPassword, request.Id);
                
                Console.WriteLine("Пользователь {0} авторизовался (подключение № {1})", request.Login, request.Id);

                return new AuthorizationResponse(AuthorizationResponseId.Successfully, authUser.Id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new AuthorizationResponse(AuthorizationResponseId.ServerException, request.Id);
            }
        }
    }
}
