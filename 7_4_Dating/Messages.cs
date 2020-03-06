using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4_Dating
{
    class Messages
    {
        public DatingProfile sender;
        public string MessageTitle;
        public string MessageData;
        public bool isRead;

        public Messages(DatingProfile sender, string MessageTitle, string MessageData)
        {
            this.sender = sender;
            this.MessageTitle = MessageTitle;
            this.MessageData = MessageData;
            isRead = false;
        }

    }
}

