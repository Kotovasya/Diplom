using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsoleTest.ServiceReference;

namespace ClientConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthorizationServiceClient client = new AuthorizationServiceClient();
            Guid id = client.Connect();
            Console.WriteLine(id);
            RegistrationRequest request = new RegistrationRequest() { Login = "Test", Password = "Test", Id = id };
            RegistrationResponse response = client.Registration(request);
            if (response.Result == ResponseId.ServerException)
                Console.WriteLine("Произошла ошибка на сервере. GUID: {0}", response.Id);
            if (response.Result == ResponseId.AlreadyRegister)
                Console.WriteLine("Данный пользователь уже зарегистрирован. Login {0} GUID: {1}", request.Login, response.Id);
            if (response.Result == ResponseId.Succesfully)
                Console.WriteLine("Регистрация прошла успешно. Login {0} GUID: {1}", request.Login, response.Id);
            Console.ReadKey();
            client.Close();
        }
    }
}
