using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ping_Pong
{
    public class Pong
    {
        public delegate void EventHandler();
        public event EventHandler PongStrike;

        public Pong(int a)
        {
            Strike(a);
        }
        public void Strike(int a)
        {
            if (a > 2)
            {
                PongStrike += Ping.DisplayInfo;
                PongStrike += Program.PingCreation;
                PongStrike();
            }
            else
            {
                Console.WriteLine("Pong промахнулся! Победил Ping");
            }
        }

        public static void DisplayInfo()
        {
            Console.WriteLine("Pong получил Ping");
        }

    }
}
