using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            Random r = new Random();

            Console.WriteLine("Input array dimension:");
            int N = Int32.Parse(Console.ReadLine());
            array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = r.Next(-100, 100);
            Console.Write("Default array: ");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();

            int max = Max(array); //array.Max();
            int min = Min(array); //array.Min();
            int sum = Sum(array); //array.Sum();
            double avg = Convert.ToDouble(sum) / N; //array.Average();
            Console.WriteLine("Maximum = {0}\nMinimum = {1}\nSum of elements = {2}\nArithmetic mean = {3}", max, min, sum, avg);
            Console.WriteLine("Odd elements:");
            OddOutput(array);
            Console.ReadKey();
        }

        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static void OddOutput(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1 || array[i] % 2 == -1)
                    Console.WriteLine(array[i]);
            }
        }
    }
}
