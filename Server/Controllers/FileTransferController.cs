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
                Context.Files.Add(new File(request.Name, request.Data));
                Context.SaveChanges();
                return new UploadFileResponse(FileTransferResponseId.Successfully);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new UploadFileResponse(FileTransferResponseId.ServerException);
            }
        }

        public DownloadFileResponse DownloadFile(DownloadFileRequest request)
        {
            try
            {
                File file = Context.Files.SingleOrDefault(f => f.Id == request.FileId);
                if (file == null)
                    return new DownloadFileResponse(FileTransferResponseId.FileNotExist);

                return new DownloadFileResponse(FileTransferResponseId.Successfully, file.ToDto());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new DownloadFileResponse(FileTransferResponseId.ServerException);
            }
        }
    }
}
