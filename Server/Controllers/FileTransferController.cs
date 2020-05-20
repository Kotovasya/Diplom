using Server.Data;
using Server.Requests.FileTransfer;
using Server.Responses.FileTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class FileTransferController : Controller
    {
        public FileTransferController(DatabaseContext context) 
            : base(context)
        {
        }

        public UploadFileResponse UploadFile(UploadFileRequest request)
        {
            try
            {
                File file = Context.Files.Add(new File(request.Name, request.Size));
                file.WriteData(0, request.Data);
                Context.SaveChanges();
                return new UploadFileResponse(FileTransferResponseId.Successfully, file.Id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new UploadFileResponse(FileTransferResponseId.ServerException);
            }
        }

        public UploadPartFileResponse UploadPartFile(UploadPartFileRequest request)
        {
            try
            {
                File file = Context.Files.Find(request.FileId);
                if (file == null)
                    return new UploadPartFileResponse(FileTransferResponseId.FileNotExist);

                file.WriteData(request.Offset, request.Data);
                Context.SaveChanges();
                return new UploadPartFileResponse(FileTransferResponseId.Successfully);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new UploadPartFileResponse(FileTransferResponseId.ServerException);
            }
        }

        public DownloadPartFileResponse DownloadPartFile(DownloadPartFileRequest request)
        {
            try
            {
                File file = Context.Files.SingleOrDefault(f => f.Id == request.FileId);
                if (file == null)
                    return new DownloadPartFileResponse(FileTransferResponseId.FileNotExist);

                byte[] data = file.ReadData(request.Offset, request.Size);

                return new DownloadPartFileResponse(FileTransferResponseId.Successfully, data);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new DownloadPartFileResponse(FileTransferResponseId.ServerException);
            }
        }
    }
}
