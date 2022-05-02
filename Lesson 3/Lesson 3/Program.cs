using System;
 namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                var actionList = new char[] { '+', '*', '/', '%', '-' };
                Console.WriteLine("Введите выражение из двух чисел.\n" + "(Если в выражении есть отрицательное число, то его необходимо вводить первым)");
                var expression = Console.ReadLine();
                var action = ' ';
                long value1;
                long value2;
                var Check = new string [5];
                string Negative;

                for (int i = 0; i < actionList.Length; i++)
                {
                    var poisk = expression.IndexOf(actionList[i]);
                    if (poisk > -1)
                    {
                        action = actionList[i];
                        //Console.WriteLine("Действие: " + action + "\n");                        
                        break;
                    }
                    else if (i == actionList.Length - 1)
                    {
                        Console.WriteLine("Ошибка! Ожидалось математическое действие (+ - * / %).");
                    }
                }
                // Console.WriteLine("Действие: " + action + "\n");

                var array = expression.Split(action);                

                if (action == '-')
                {
                    int.TryParse(array[0], out var GdeMinus);
                   // Console.WriteLine("Где минус: " + GdeMinus);

                   if (GdeMinus == 0)
                    {
                        array[0] = ("-" + array[1]);
                        array[1] = array[2];

                        if (array.Length > 3)
                        {
                            Console.WriteLine("Вы пытаетесь выполнить более одного математического действия\n");
                            continue;
                        }                    
                    }
                   else
                    {
                        if (array.Length > 2)
                        {
                            Console.WriteLine("Вы пытаетесь выполнить более одного математического действия\n");
                            continue;
                        }
                    }
                  
                }
                else
                {
                    Negative = array[0];

                    if (array.Length > 2)
                    {
                        Console.WriteLine("Вы пытаетесь выполнить более одного математического действия\n");
                        continue;
                    }

                    if (Negative.StartsWith("-"))
                    {
                        for (int i = 1; i < array.Length; i++)
                        {
                            var CheckActionNumber = array[i];
                            Check = CheckActionNumber.Split(actionList);
                            if (Check.Length > 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            var CheckActionNumber = array[i];
                            Check = CheckActionNumber.Split(actionList);
                            if (Check.Length > 1)
                            {
                                break;
                            }
                        }
                    }

                    if (Check.Length > 1)
                    {
                        Console.WriteLine("Вы пытаетесь выполнить более одного математического действия\n");
                        continue;
                    }
                }           

                try
                 {
                     value1 = long.Parse(array[0]);
                     value2 = long.Parse(array[1]);                      
                 }
                 catch (FormatException)
                 {
                     Console.WriteLine("Ошибка! Используйте целые числа в диапазоне от -9*10^18 до 9*10^18\n");
                     continue;
                 }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка! Одно из значений не входит в диапазон от -9*10^18 до 9*10^18\n");
                    continue;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Необходимо ввести выражение из двух чисел. Например, 5+5\n");
                    continue;
                }
                
                    Switch(action, value1, value2);
            }
        }

        public static void Switch(char action, long value1, long value2)
        {
            switch (action)
            {
                case '+':
                    long result = Summ(value1, value2);                   
                    Console.WriteLine("Результат: " + result+ "\n");                   
                    break;
                case '-':
                    long result1 = Difference(value1, value2);                   
                    Console.WriteLine("Результат: " + result1+ "\n");                 
                    break;
                case '*':
                    long result2 = Multiplication(value1, value2);                      
                    Console.WriteLine("Результат: " + result2 + "\n");                    
                    break;
                case '/':
                    long result3 = Divide(value1, value2);
                    if (value2 > 0)
                    {
                        Console.WriteLine("Результат: " + result3 + "\n");
                    }                                       
                    break;
                case '%':
                    long result4 = RemainderOfDivision(value1, value2);
                    Console.WriteLine("Результат: " + result4 + "\n");                    
                    break;
                case ' ':
                    Console.WriteLine();
                    break;
            }
        } 
        public static long Summ(long value1, long value2)
        {
            long summ=0;
            try
            {
                summ = checked(value1 + value2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка! Результат находится за пределами диапазона [-9*10^18 ; 9*10^18]\n");
                Main();
            }
            return summ;            
        }
        public static long Difference(long value1, long value2)
        {
            long difference = 0;
            try
            {
                difference = checked(value1 - value2);
            }
           catch (OverflowException)
            {
                Console.WriteLine("Ошибка! Результат находится за пределами диапазона [-9*10^18 ; 9*10^18]\n");
                Main();
            }
            return difference;
        }
        public static long Multiplication(long value1, long value2)
        {
            long multiplication = 0;            
            try 
            {                
                multiplication = checked(value1 * value2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка! Результат находится за пределами диапазона [-9*10^18 ; 9*10^18]\n");
                Main();
            }
            return multiplication;
        }
        public static long Divide(long value1, long value2)
        {
            long Divide = 0;
            try
            {
                Divide = value1 / value2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! На ноль делить нельзя!\n");
                Main();
            }
            return Divide;
        }
        public static long RemainderOfDivision(long value1, long value2)
        {
            long RemainderOfDivision = value1 % value2;
            return RemainderOfDivision;
        }
    }
}

