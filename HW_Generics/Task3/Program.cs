using System;
using Task1;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.Add(r.Next(100));
            }

            int[] arr = list.GetArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array[{0}]: {1}", i, arr[i]);
            }
            Console.ReadKey();
        }
    }
}
