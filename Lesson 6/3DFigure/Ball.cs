using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFigure
{
    public class Ball : Shape
    {
        public int r;
        const double pi = 3.1415;

        public Ball(int r)
        {
            this.r = r;
            volume = Volume();
            Console.WriteLine($"Ball volume = {volume:f3}");
        }
        public override double Volume()
        {
            return 4 * pi * r * r * r / 3;
        }
    }
}
