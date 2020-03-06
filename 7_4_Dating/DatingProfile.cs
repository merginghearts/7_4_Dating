using System;

namespace _7_4_Dating
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile doctor = new DatingProfile("Doctor", "?", 900, "Depends");
            doctor.WriteBio("Likes jelly babies and long time/distance relationships!");

            DatingProfile rose = new DatingProfile("Rose", "Tyler", 21, "Female");
            rose.WriteBio("Feels like I am stuck in another dimension!");

            doctor.SendMessage("Hello Rose", "I don't want to go!", rose);
            


        }
        
    }
}




