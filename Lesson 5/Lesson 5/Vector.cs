using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Vector
    {
        public int[] array1;
        public int[] array2;

        public Vector(int[] array1)
        {
            this.array1 = array1;          
            var result = VectorLenght(array1);
            Console.WriteLine($"\nДлина вектора ={result:f3}\n");        
        }

        public Vector(int[] array1, int[] array2)
        {
            this.array1 = array1;
            this.array2 = array2;

            var result = VectorScalarMult(array1, array2);
            Console.WriteLine($"Скалярное произведение векторов ={result:f3}\n");

            var result1 = VectorVectMult(array1, array2);
            Console.Write("Векторное произведение векторов = ");
            foreach (int i in result1)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("\n");

            var result2 = VectorAngle(array1, array2);
            Console.WriteLine($"Угол между векторами ={result2:f3}\n");

            var result3 = VectorSumm(array1, array2);
            Console.Write("Сумма векторов = ");
            foreach (int i in result3)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("\n");

            var result4 = VectorDifference(array1, array2);
            Console.Write("Разность векторов = ");
            foreach (int i in result4)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("\n");
        }

        //Длина вектора
        public static double VectorLenght(int[] array1)
        {
            var lenght = Math.Sqrt(Math.Pow(array1[0], 2)+ Math.Pow(array1[1], 2)+ Math.Pow(array1[2], 2));            
            return lenght;
        }
        //Скалярное произведение векторов
        public static int VectorScalarMult(int[] array1, int[] array2)
        {
            var scalarProduct =array1[0] * array2[0] + array1[1] * array2[1] + array1[2] * array2[2];
            return scalarProduct;
        }

        //Векторное произведение векторов
        public static int[] VectorVectMult(int[] array1, int[] array2)
        {
            int[] vectMult = new int[array1.Length];
            vectMult[0] = array1[1] * array2[2] - array1[2] * array2[1];
            vectMult[1] = array1[2] * array2[0] - array1[0] * array2[2];
            vectMult[2] = array1[0] * array2[1] - array1[1] * array2[0];
            return vectMult;
        }
        //Угол между векторами
        public static double VectorAngle(int[] array1, int[] array2)
        {
            var cosAngle = VectorScalarMult(array1, array2) / (VectorLenght(array1) * VectorLenght(array2));
            var angleStr = cosAngle.ToString();
            var angle = MathF.Acos(float.Parse(angleStr)) * 57.2958;
            return angle;
        }
        //Сумма векторов
        public static int [] VectorSumm(int[] array1, int[] array2)
        {
            int[] summ = new int[array1.Length];
            for (int i=0; i<summ.Length; i++)
            {
                summ[i] = array1[i] + array2[i]; 
            }
            return summ;
        }

        //Разность векторов
        public static int[] VectorDifference(int[] array1, int[] array2)
        {
            int[] differense = new int[array1.Length];
            for (int i = 0; i < differense.Length; i++)
            {
                differense[i] = array1[i] - array2[i];
            }
            return differense;
        }
    }
}
