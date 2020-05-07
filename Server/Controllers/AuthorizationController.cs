using Server.Data;
using Server.Models.Entities;
using Server.Requests.Authorization;
using Server.Responses.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class AuthorizationController
    {
        private DatabaseContext _context;
        public AuthorizationController(DatabaseContext context)
        {
            _context = context;
        }

        public RegistrationResponse RegisterUser(RegistrationRequest request)
        {
            try
            {
                if (_context.Users.Any(u => u.Login.ToLower() == request.Login.ToLower()))
                    return new RegistrationResponse(ResponseId.AlreadyRegister, request.Id);

                Console.WriteLine("Пользователь {0} зарегистрирован (подключение № {1})", request.Login, request.Id);
                _context.Users.Add(new User(request.Id, request.Login, request.Password));
                _context.SaveChangesAsync();

                return new RegistrationResponse(ResponseId.Succesfully, request.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new RegistrationResponse(ResponseId.ServerException, request.Id);
            }
        }

        public AuthorizationResponse AuthorizationUser(AuthorizationRequest request)
        {
            try
            {
                User authUser = _context.Users.SingleOrDefault(u => u.Login.ToLower() == request.Login.ToLower());
                if (authUser == null)
                    return new AuthorizationResponse(ResponseId.WrongLogin, request.Id);

                if (authUser.Password != request.Password)
                    return new AuthorizationResponse(ResponseId.WrongPassword, request.Id);
                
                Console.WriteLine("Пользователь {0} авторизовался (подключение № {1})", request.Login, request.Id);
                return new AuthorizationResponse(ResponseId.Succesfully, authUser.Id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new AuthorizationResponse(ResponseId.ServerException, request.Id);
            }
        }
    }
}
