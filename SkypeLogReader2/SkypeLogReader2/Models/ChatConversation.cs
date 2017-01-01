using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeLogReader2.Models
{
    class ChatConversation
    {
        public Int32 ID { get; set; }

        public string DisplayName { get; set; }

        public ConversationType Type { get; set; }
    }

    enum ConversationType
    {
        SingleChat = 1,
        GroupChat = 2,
    }
}
