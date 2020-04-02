using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4_Dating
{
    class Messages
    {
        public DatingProfile sender;
        public string Message_title;
        public string Message_data;
        public bool isRead;

        public Messages(DatingProfile sender, string MessageTitle, string MessageData)
        {
            this.sender = sender;
            this.Message_title = MessageTitle;
            this.Message_data = MessageData;
            isRead = false;
        }

    }
}

