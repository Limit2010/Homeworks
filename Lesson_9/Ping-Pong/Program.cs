using System;

namespace Ping_Pong
{
    public class Program
    {
        public static void Main()
        {
            var ping = new Ping(Random());
           
            Console.ReadLine();
        }

        public static int Random()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            return magicNumber;
        }

        public static void PingCreation()
        {
            new Ping(Random());
        }
        public static void PongCreation()
        {
            new Pong(Random());
        }
    }
}