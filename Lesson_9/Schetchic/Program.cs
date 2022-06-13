using System;

namespace Schetchic
{
    public class Program
    {
        public static void Main()
        {
            var p = new Counter();
            var h1 = new Handler1();
            var h2 = new Handler2();

            p.Count += Handler1.Message;
            p.Count += Handler2.Message;

            p.OnCount();
            Console.ReadLine();
        }
    }
}