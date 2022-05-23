using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFigure
{
    public class Box : Shape
    {
        public int h;

        public Box()
        {

        }
        public Box(int h)
        {
            this.h = h;
            volume = Volume();
            Console.WriteLine($"Box Volume = {volume:f3}");
            
        }
        public override double Volume()
        {            
            return Math.Pow(h,3);            
        }
       
    }
}
