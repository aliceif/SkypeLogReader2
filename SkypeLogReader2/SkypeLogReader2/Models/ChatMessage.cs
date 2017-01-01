using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeLogReader2.Models
{
    class ChatMessage
    {
        public Int32 ID { get; set; }

        public ChatConversation Conversation { get; set; }

        public ChatUser Sender { get; set; }

        public string SenderNameThen { get; set; }
        public string SenderNameNow { get { return Sender?.DisplayName; } }

        public DateTime TimeStamp { get; set; }

        public string MessageContent { get; set; }
    }
}
