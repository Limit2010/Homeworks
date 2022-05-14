using System;
namespace Lesson_5;
 public class Program
{

    public static void Main()
    {
        while(true)
        {
            Console.WriteLine("Задайте первый вектор в пространстве в формате x y z\nИспользуйте только целые числа!");
            var vec1 = Console.ReadLine();
            var list1str = new List<string>(vec1.Split(' '));
            var array1 = new int[list1str.Count];
            if (list1str.Count != 3)
            {
                Console.WriteLine("\nОшибка! Введите 3 координаты вектора через пробел\n");
                continue;
            }
            try
            {
                for (int i = 0; i < list1str.Count; i++)
                {                    
                    array1[i] = int.Parse(list1str[i]);
                    
                    //Console.Write(array1[i] + " ");
                }
            }               
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка! Необходимо указать координаты вектора в целых числах\n");
                continue;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка! Координаты вектора должны лежать в пределах от -2*10^9 до 2*10^9\n");
                continue;
            }


            Console.WriteLine("\nЗадайте второй вектор в пространстве в формате x y z\nИспользуйте только целые числа!");
            var vec2 = Console.ReadLine();            
            var list2str = new List<string>(vec2.Split(' '));
            var array2 = new int[list2str.Count];
            if (list2str.Count != 3)
            {
                Console.WriteLine("\nОшибка! Введите 3 координаты вектора через пробел\n");
                continue;
            }
            try
            {
                for (int i = 0; i < list2str.Count; i++)
                {
                    array2[i] = int.Parse(list2str[i]);

                    //Console.Write(array2[i] + " ");
                }
            }          
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка! Необходимо указать координаты вектора в целых числах\n");
                continue; ;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка! Координаты вектора должны лежать в пределах от -2*10^9 до 2*10^9\n");
                continue;
            }

            var v1 = new Vector(array1);
            var v2 = new Vector(array2);
            var v3 = new Vector(array1, array2);
        }              

    }
}