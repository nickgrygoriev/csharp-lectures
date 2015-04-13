using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
                Console.Write(i+" ");
            Console.WriteLine();

            int[] reverseArray = MyReverse(array);
            Console.Write("Reverse array: ");
            foreach (int i in reverseArray)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Input start index for subarray:");
            int index = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input dimension of subarray:");
            int count = Int32.Parse(Console.ReadLine());
            int[] subArray = SubArray(array, index, count);
            Console.Write("Subarray: ");
            foreach (int i in subArray)
                Console.Write(i + " ");

            Console.ReadKey();
        }

        static int[] MyReverse(int[] array)
        {
            //Array.Reverse(array);

            int[] reverse = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                reverse[i] = array[array.Length - i - 1];
            return reverse;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                if (index + i > array.Length - 1)
                    subArray[i] = 1;
                else
                    subArray[i] = array[index + i];
            }
            return subArray;
        }
    }
}
