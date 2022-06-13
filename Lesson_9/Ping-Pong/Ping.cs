using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ping_Pong
{
    public class Ping
    {
        public delegate void EventHandler();
        public event EventHandler PingStrike;
        
        public Ping(int a)
        {
            Strike(a);
        }
        public void Strike(int a)
        {
            if (a > 2)
            {
                PingStrike += Pong.DisplayInfo;
                PingStrike += Program.PongCreation;
                PingStrike();
            }
            else
            {
                Console.WriteLine("Ping промахнулся! Победил Pong");
            }
        }

        public static void DisplayInfo()
        {
            Console.WriteLine("Ping получил Pong");
        }
    }
}
