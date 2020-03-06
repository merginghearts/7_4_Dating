using System;
using System.Collections.Generic;
using System.Text;


namespace _7_4_Dating
{
    class DatingProfile
    {
        private string lastName;
        public string firstName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> myMessages;

        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>(); 
        }
        public void WriteBio(string text)
        {
            bio = text;
        }
        public void ReadMessage(string text)
        {

        }
        public void SendMessage(string messageTitle, string MessageData, DatingProfile toProfile)
        {

        }
        class Messages
        {
            public DatingProfile sender;
            public string MessageTitle;
            public string MessageData;
            private bool isRead;

            public Messages(DatingProfile sender, string MessageTitle, string MessageData)
            {
                this.sender = sender;
                this.MessageTitle = MessageTitle;
                this.MessageData = MessageData;
                isRead = false;
            }

        }
    }
}

            




       