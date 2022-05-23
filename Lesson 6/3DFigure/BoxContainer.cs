using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFigure
{
    public class BoxContainer : Box
    {
        public List <Shape> shapes;
        public double maxVolume;
        public double currentVolume;

        public BoxContainer(int h)
        {
            this.h = h;
            maxVolume = Volume();
            Console.WriteLine($"Box container volume = {maxVolume}");
            currentVolume = 0;
        }

        public void Add(List <Shape> list)
        {
            Console.WriteLine("");
            shapes = new List<Shape>();
            for (int i=0; i < list.Count; i++)
            {              
                if (currentVolume >= maxVolume)
                {
                    Console.WriteLine("Нет места");
                    Console.WriteLine($"Фигура №{i + 1} ({list[i].ToString().Remove(0, 10)}) не входит. Место в контэйнере закончилось");
                    Console.WriteLine("Список фигур в контэйнере: ");

                    foreach (Shape shape in shapes)
                    {
                        var figureType = shape.ToString();
                        Console.WriteLine($"{figureType.Remove(0, 10)} (vol {shape.volume:f3}) ");
                    }
                    
                    break;
                }

                var newShapeVolume = list[i].Volume();
               // Console.WriteLine($"Объем переданной фигуры №{i+1}= {newShapeVolume:f3}");
                
                if (newShapeVolume + currentVolume > maxVolume)
                {
                    currentVolume = currentVolume + newShapeVolume;
                    Console.WriteLine($"Фигура №{i + 1} ({list[i].ToString().Remove (0, 10)}) не входит. Место в контэйнере закончилось");
                    Console.WriteLine("Список фигур в контэйнере: ");
                   
                    foreach (Shape shape in shapes)
                    {
                        var figureType = shape.ToString();
                        Console.WriteLine($"{figureType.Remove(0, 10)} (vol {shape.volume:f3}) ");
                    }
                    break;
                }                
                shapes.Add(list[i]);
                currentVolume = currentVolume + newShapeVolume;
            }   
            
            if (currentVolume < maxVolume)
            {
                Console.WriteLine("Все фигуры поместились в контэйнер.\nСписок фигур в контэйнере: ");

                foreach (Shape shape in shapes)
                {
                    var figureType = shape.ToString();
                    Console.WriteLine($"{figureType.Remove(0, 10)} (vol {shape.volume:f3}) ");
                }
            }
        }
    }
}
