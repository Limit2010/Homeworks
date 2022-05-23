using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFigure
{
    public class Cylinder : Shape
    {
        public int r;
        public int h;
        const double pi = 3.1415;

        public Cylinder (int r, int h)
        {
            this.r = r;
            this.h = h;
            volume = Volume();
            Console.WriteLine($"Cylinder volume = {volume:f3}");
        }

        public override double Volume()
        {
            return pi * r * r * h;
        }
    }
}
