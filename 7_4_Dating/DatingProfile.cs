using System;
using System.Collections.Generic;
using System.Text;


namespace _7_4_Dating
{
    class DatingProfile
    {
        public string first_name;
        private string last_name;
        public int Age;
        public string gender;
        public string Bio;
        private List<Messages> my_Messages;

        public DatingProfile(string first_name, string last_name, int Age, string gender)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.Age = Age;
            this.gender = gender;
            my_Messages = new List<Messages>();
        }

        public void WriteBio(string text)
        {
            Bio = text;

        }
        public void AddToInbox(Messages message)
        {
            my_Messages.Add(message);
        }
        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }
        public void ReadMessage()
        {
            foreach (Messages message in my_Messages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.Message_title);
                    Console.WriteLine(message.Message_data);
                    message.isRead = true;
                }
            }

        }
    }
}




