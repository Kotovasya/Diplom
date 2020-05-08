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
        public class ClientModel : IGlobalServiceCallback
        {
            public GlobalServiceClient Client { get; private set; }

            public ClientModel()
            {
                Client = new GlobalServiceClient(new InstanceContext(this));
            }

            public void OnUserLogined(UserLoginedEventArgs args)
            {
                Console.WriteLine("Пользователь {0} авторизовался. GUID {1}", args.Login, args.Id);
            }

            public void OnUserRegistered(UserRegisteredEventArgs args)
            {
                Console.WriteLine("Пользователь {0} зарегистрировался. GUID {1}", args.Login, args.Id);
            }

            public void OnSendedMessage(SendedMessageEventArgs args)
            {
                Console.WriteLine("[{0}] {1}: {2}", DateTime.Now.ToLongTimeString(), args.Sender, args.Text);
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
            if (response.Result == AuthorizationResponseId.ServerException)
                Console.WriteLine("Произошла ошибка на сервере. GUID: {0}", response.Id);
            if (response.Result == AuthorizationResponseId.AlreadyRegister)
                Console.WriteLine("Данный пользователь уже зарегистрирован. Login {0} GUID: {1}", request.Login, response.Id);
            if (response.Result == AuthorizationResponseId.Successfully)
                Console.WriteLine("Регистрация прошла успешно. Login {0} GUID: {1}", request.Login, response.Id);
            Console.WriteLine("Введите сообщение:");
            string text = Console.ReadLine();
            SendMessageRequest messageRequest = new SendMessageRequest() { Id = id, Text = text };
            SendMessageResponse messageResponse = model.Client.SendMessage(messageRequest);
            if (messageResponse.Result == MessagingResponseId.Successfully)
                Console.WriteLine("Собщение успешно доставлено");
            if (messageResponse.Result == MessagingResponseId.ServerException)
                Console.WriteLine("Произошла ошибка на сервере.");
            Console.ReadKey();
            model.Client.Close();
        }
    }
}
