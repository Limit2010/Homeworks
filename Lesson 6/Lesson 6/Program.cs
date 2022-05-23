using System;
    namespace Lesson_6
{
public class Program
    {

        public static void Main()
        {
            var p1 = new Point("A", 0, 0);
            var p2 = new Point("B", 0, 5);
            var p3 = new Point("C", 6, 5);
            var p4 = new Point("D", 6, 0);
            var p5 = new Point("E", 6, -4);            

            var fig1 = new Polygon(p1, p2, p3);
            var fig2 = new Polygon(p1, p2, p3, p4);
            var fig3 = new Polygon(p1, p2, p3, p4, p5);

            Console.ReadLine();

            
        }
    
    }
}
