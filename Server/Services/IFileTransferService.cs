using Server.Requests.FileTransfer;
using Server.Responses.FileTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    [ServiceContract]
    public interface IFileTransferService
    {
        [OperationContract]
        UploadFileResponse UploadFile(UploadFileRequest request);

        [OperationContract]
        UploadPartFileResponse UploadPartFile(UploadPartFileRequest request);

        [OperationContract]
        DownloadPartFileResponse DownloadPartFile(DownloadPartFileRequest request);
    }
}
