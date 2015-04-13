using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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

            Console.WriteLine("Input new element:");
            int value = Int32.Parse(Console.ReadLine());
            ExtendArray(ref array, value);
            Console.Write("Extended array: ");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.ReadKey();
        }

        static void ExtendArray(ref int[] array, int value)
        {
            int[] extendedArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                extendedArray[i] = array[i];
            extendedArray[array.Length] = value;
            array = extendedArray;

            //Array.Resize(ref array, array.Length + 1);
            //array[array.Length - 1] = value;
        }
    }
}
