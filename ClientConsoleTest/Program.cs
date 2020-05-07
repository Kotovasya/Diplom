using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsoleTest.ServiceReference;
using System.ServiceModel;

namespace ClientConsoleTest
{
    class Program
    {
        public class ClientModel : IAuthorizationServiceCallback
        {
            public AuthorizationServiceClient Client { get; private set; }

            public ClientModel()
            {
                Client = new AuthorizationServiceClient(new InstanceContext(this));
            }

            public void BlaBlac()
            {
                throw new NotImplementedException();
            }

            public void OnUserLogined(UserLoginedEventArgs args)
            {
                Console.WriteLine("Пользователь {0} авторизовался. GUID {1}", args.Login, args.Id);
            }

            public void OnUserRegistered(UserRegisteredEventArgs args)
            {
                Console.WriteLine("Пользователь {0} зарегистрировался. GUID {1}", args.Login, args.Id);
            }
        }


        static void Main(string[] args)
        {
            ClientModel model = new ClientModel();
            Guid id = model.Client.Connect();
            Console.WriteLine("Для регистрации, введите ваш логин:");
            string login = Console.ReadLine();
            Console.WriteLine("Пароль:");
            string password = Console.ReadLine();
            RegistrationRequest request = new RegistrationRequest() { Login = login, Password = password, Id = id };
            RegistrationResponse response = model.Client.Registration(request);
            if (response.Result == ResponseId.ServerException)
                Console.WriteLine("Произошла ошибка на сервере. GUID: {0}", response.Id);
            if (response.Result == ResponseId.AlreadyRegister)
                Console.WriteLine("Данный пользователь уже зарегистрирован. Login {0} GUID: {1}", request.Login, response.Id);
            if (response.Result == ResponseId.Succesfully)
                Console.WriteLine("Регистрация прошла успешно. Login {0} GUID: {1}", request.Login, response.Id);
            Console.ReadKey();
            model.Client.Close();
        }
    }
}
