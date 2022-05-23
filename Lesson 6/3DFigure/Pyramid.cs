using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFigure
{
    public class Pyramid : Shape
    {
        public int s;
        public int h;

        public Pyramid(int s, int h)
        {
            this.s = s;
            this.h = h;
            volume = Volume();
            Console.WriteLine($"Pypamid volume = {volume:f3}");
        }
        public override double Volume()
        {
            return s * h / 3;
        }
    }
}
