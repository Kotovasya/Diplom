﻿using Server.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Messaging
{
    [DataContract]
    public class SendMessageResponse
    {
        [DataMember]
        public MessageDto Message { get; set; }

        [DataMember]
        public MessagingResponseId Result { get; set; }

        public SendMessageResponse(MessagingResponseId result)
        {
            Result = result;
        }

        public SendMessageResponse(MessageDto message, MessagingResponseId result)
        {
            Message = message;
            Result = result;
        }
    }
}
