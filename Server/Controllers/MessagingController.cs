﻿using Server.Data;
using Server.Requests.Messaging;
using Server.Responses.Messaging;
using System;
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
                User sender = Context.Users.SingleOrDefault(u => u.Id == request.Id);
                Context.Messages.Add(new Message(request.Text, sender));
                return new SendMessageResponse(MessagingResponseId.Successfully);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new SendMessageResponse(MessagingResponseId.ServerException);
            }
        }
    }
}