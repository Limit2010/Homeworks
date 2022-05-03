using System;
namespace NewApp
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                int arrayLength = -1;

                Console.WriteLine("Введите длину массива (от 1 до 2*10^9)");
                try
                {
                    arrayLength = Int32.Parse(Console.ReadLine());
                    if (arrayLength <= 0)
                    {
                        throw new FormatException();
                    }
                    /* else if (arrayLength == -1)
                     {
                         Console.WriteLine("Ошибка! Не указана длина массива");
                     }*/
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите целое число в диапазоне от 1 до 2*10^9\n");
                    Main();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка! Введите целое число в диапазоне от 1 до 2*10^9\n");
                    Main();
                }

                Console.WriteLine("\nВведите все члены массива через пробел.\n" + "Массив должен состоять из целых чисел в диапазоне от -2*10^9 до 2*10^9");

                var arrayEntered = Console.ReadLine().Split(' ');

                if (arrayEntered.Length != arrayLength)
                {
                    Console.WriteLine("Количество членов массива не совпадает с указанной длиной массива\n");
                    Main();
                }

                var array = new Int32[arrayEntered.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    try
                    {
                        array[i] = Int32.Parse(arrayEntered[i]);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка! Встречен член массива не соответствующий требованиям\n");
                        Main();
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка! Встречен член массива не соответствующий требованиям\n");
                        Main();
                    }
                }
                
               /* for (int i = 0; i < array.Length; i++) // Вывод массива
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine("\n");*/

                Poisk(array);
            }
        }
        public static int Poisk(int[] array)
        {
            var maxValue = array.Max();
            // Console.WriteLine("Наибольший член массива " + maxValue + "\n");
            
            int[] array1 = Array.FindAll(array, (int x) => x == array[0]);

            if (array.Length == array1.Length)
            {
                Console.WriteLine("Все члены массива имеют одно и то же значение. Второго наибольшего значения не существует!\n");
                Main();
            }

            for (int i=0; i<array.Length; i++)
            {
                
               if (array[i].CompareTo(maxValue) == 0)
                {
                    Array.Fill(array, -2147483648, i, 1);
                }
            }
            
                                  
            maxValue = array.Max();
            Console.WriteLine("Второй наибольший член массива " + maxValue + "\n");
            return maxValue;
        }
    }
}