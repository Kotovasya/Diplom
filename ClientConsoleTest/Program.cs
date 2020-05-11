using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsoleTest.ServiceReference;
using System.ServiceModel;
using System.IO;

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
                Console.WriteLine("[{0}] {1}: {2}", DateTime.Now.ToLongTimeString(), args.Message.Sender, args.Message.Text);
            }
        }

        public static ClientModel Model;

        static void Main(string[] args)
        {
            Model = new ClientModel();
            Guid id = Model.Client.Connect();

            AuthorizationRequest request = new AuthorizationRequest() { Login = "Test", Password = "Test", Id = id };
            AuthorizationResponse response = Model.Client.Authorization(request);
            if (response.Result == AuthorizationResponseId.ServerException)
                Console.WriteLine("Произошла ошибка на сервере. GUID: {0}", response.Id);
            if (response.Result == AuthorizationResponseId.Successfully)
                Console.WriteLine("Регистрация прошла успешно. Login {0} GUID: {1}", request.Login, response.Id);
            id = response.Id;

            //using (FileStream stream = File.OpenRead(@"E:\4 курс\Диплом\Diploma\ClientConsoleTest\FileTest.txt"))
            //{
            //    byte[] data = new byte[stream.Length];
            //    int size = stream.Read(data, 0, data.Length);
            //    if (size > 0)
            //    {
            //        UploadFileRequest fileRequest = new UploadFileRequest() { Id = id, Name = stream.Name, Data = data };
            //        UploadFileResponse fileResponse = Model.Client.UploadFile(fileRequest);
            //        if (fileResponse.Result == FileTransferResponseId.Successfully)
            //            Console.WriteLine("Файл успешно загружен на сервер");
            //        if (fileResponse.Result == FileTransferResponseId.ServerException)
            //            Console.WriteLine("Во время загрузки файла на сервер, на сервере произошла ошибка");
            //    }
            //}

            DownloadFileRequest fileRequest = new DownloadFileRequest() { Id = id, FileId = new Guid("00000000-0000-0000-0000-000000000000") };
            DownloadFileResponse fileResponse = Model.Client.DownloadFile(fileRequest);
            if (fileResponse.Result == FileTransferResponseId.FileNotExist)
                Console.WriteLine("Файл на сервере не найден");
            if (fileResponse.Result == FileTransferResponseId.ServerException)
                Console.WriteLine("При скачивании файла на сервере возникла ошибка");
            if (fileResponse.Result == FileTransferResponseId.Successfully)
            {
                using (FileStream stream = new FileStream(fileResponse.File.Name, FileMode.Create))
                {
                    stream.Write(fileResponse.File.Data, 0, fileResponse.File.Data.Length);
                    Console.WriteLine("Файл успешно загружен");
                }
            }
            Console.ReadLine();
            Model.Client.Close();
        }
    }
}
