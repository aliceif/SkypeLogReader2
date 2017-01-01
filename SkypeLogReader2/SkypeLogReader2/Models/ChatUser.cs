using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeLogReader2.Models
{
    class ChatUser
    {
        public Int32 ID { get; set; }

        public string SkypeName { get; set; }
        public string DisplayName { get; set; }

        public string AboutText { get; set; }
        public string MoodText { get; set; }
    }
}
