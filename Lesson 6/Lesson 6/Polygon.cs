using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Polygon
    {
        double perimetr;
        public Polygon (Point p1, Point p2, Point p3)
        {
            var list = new List<Point> {p1, p2, p3};
            perimetr = Perimetr(list);
            Console.WriteLine($"Периметр треугольника = {perimetr:f3}");
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4)
        {
            var list = new List<Point> { p1, p2, p3, p4 };
            perimetr = Perimetr(list);
            Console.WriteLine($"Периметр прямоугольника = {perimetr:f3}");
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            var list = new List<Point> { p1, p2, p3, p4, p5 };
            perimetr = Perimetr(list);
            Console.WriteLine($"Периметр пятиугольника = {perimetr:f3}");
        }

        public double Perimetr(List<Point> list)
        {
            
            double[] array = new double [list.Count];  
            
                for (int i = 0; i < list.Count; i++)
            {
                if (i <= list.Count-2)
                {
                   array[i] = Math.Sqrt(Math.Pow(list[i + 1].x - list[i].x, 2) + Math.Pow(list[i + 1].y - list[i].y, 2));
                }
                
                else
                {
                    array[i] = Math.Sqrt(Math.Pow(list[i].x - list[0].x, 2) + Math.Pow(list[i].y - list[0].y, 2));
                }

            }

             return array.Sum(x=>x);           
        }        
    }
}
