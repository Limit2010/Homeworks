using System;
 namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter the first value");
                long.TryParse(Console.ReadLine(), out var value1);
                if (value1 == 0)
                {
                    Console.WriteLine("Eror. Please use integers from -9*10^18 to 9*10^18");
                    Console.WriteLine();
                    continue;                   
                }

                Console.WriteLine("Enter math expression");
                var action = Console.ReadLine();
                if (action != "+" & action != "-" & action != "*" & action != "/" & action != "%")
                {
                    Console.WriteLine("Eror. Please use one of the Math action (+ - * / %)");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Enter the second value");
                long.TryParse(Console.ReadLine(), out var value2);
                if (value2 == 0)
                {
                    Console.WriteLine("Eror. Please use integers from -9*10^18 to 9*10^18");
                    Console.WriteLine();
                    continue;
                }



                switch (action)
                {
                    case "+":
                        long result = Summ(value1, value2);
                        if (result > 9000000000000000000)
                        {
                            Console.WriteLine("The result is out of range [-9*10^18 to 9*10^18]");
                            Console.WriteLine();
                            continue;
                        }
                        Console.WriteLine("result: " + result);
                        Console.WriteLine();                                            
                        break;
                    case "-":
                        long result1 = difference(value1, value2);
                        if (result1 < -9000000000000000000)
                        {
                            Console.WriteLine("The result is out of range [-9*10^18 to 9*10^18]");
                            Console.WriteLine();
                            continue;
                        }
                        Console.WriteLine("result: " + result1);
                        Console.WriteLine();
                        break;
                    case "*":
                        long result2 = multiplication(value1, value2);
                        if (result2 > 9000000000000000000)
                        {
                            Console.WriteLine("The result is out of range [-9*10^18 to 9*10^18]");
                            Console.WriteLine();
                            continue;
                        }
                        else if (result2 < -9000000000000000000)
                        {
                            Console.WriteLine("The result is out of range [-9*10^18 to 9*10^18]");
                            Console.WriteLine();
                            continue;
                        }
                        Console.WriteLine("result: " + result2);
                        Console.WriteLine();
                        break;
                    case "/":
                        long result3 = Divide(value1, value2);
                        Console.WriteLine("result: " + result3);
                        Console.WriteLine();
                        break;
                    case "%":
                        long result4 = RemainderOfDivision(value1, value2);
                        Console.WriteLine("result: " + result4);
                        Console.WriteLine();
                        break;

                }
            }
        }
        public static long Summ(long value1, long value2)
        {
            long summ = value1 + value2;
            return summ;
            
        }
        public static long difference(long value1, long value2)
        {
            long difference = value1 - value2;
            return difference;
        }
        public static long multiplication(long value1, long value2)
        {
            long multiplication = value1 * value2;
            return multiplication;
        }
        public static long Divide(long value1, long value2)
        {
            long Divide = value1 / value2;
            return Divide;
        }
        public static long RemainderOfDivision(long value1, long value2)
        {
            long RemainderOfDivision = value1 % value2;
            return RemainderOfDivision;
        }
    }

}

