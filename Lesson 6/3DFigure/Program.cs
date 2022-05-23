using System;

namespace _3DFigure
{
    public  class Program
    {
        public static void Main()
        {
            var list = new List<Shape>();

            Console.WriteLine("Список созданых фигур:");

            var b = new Box (4);
            var c = new Cylinder (5, 10);
            var p = new Pyramid (10, 20);
            var ball = new Ball (10);
            
            list.Add(b);
            list.Add(c);
            list.Add(p);
            list.Add(ball);
            
            var bC = new BoxContainer(10);

            bC.Add(list);

            Console.ReadLine();
        }
    }
}
    

