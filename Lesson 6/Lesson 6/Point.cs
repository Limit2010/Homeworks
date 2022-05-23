using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Point
    {
       public int x { get;}
        public int y { get;}
        public string name { get;}

        public Point (string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            //Console.WriteLine($"Точка {name}: ({x},{y})");
        }
        
        
    }
}
