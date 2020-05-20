using Server.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Responses.Dialogs
{
    [DataContract]
    public class GetMessagesResponse
    {
        [DataMember]
        public DialogResponseId Result { get; set; }

        [DataMember]
        MessageDto[] Messages { get; set; }

        public GetMessagesResponse(DialogResponseId result)
        {
            Result = result;
        }

        public GetMessagesResponse(DialogResponseId result, MessageDto[] messages)
            : this(result)
        {
            Messages = messages;
        }
    }
}
