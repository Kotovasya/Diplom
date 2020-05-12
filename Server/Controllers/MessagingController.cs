using Server.Data;
using Server.Requests.Messaging;
using Server.Responses.Messaging;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class MessagingController : Controller
    {
        public MessagingController(DatabaseContext context)
            : base(context)
        {
        }

        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            try
            {
                User sender = Context.Users.Find(request.Id);
                Dialog dialog = Context.Dialogs.Find(request.DialogId);
                Message message = Context.Messages.Add(new Message(request.Text, request.Id, request.FileId));
                Context.SaveChanges();
                dialog.Messages.Add(message);
                Context.Entry(dialog).State = EntityState.Modified;
                Context.SaveChanges();
                return new SendMessageResponse(message.ToDto(), MessagingResponseId.Successfully);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new SendMessageResponse(MessagingResponseId.ServerException);
            }
        }
    }
}
