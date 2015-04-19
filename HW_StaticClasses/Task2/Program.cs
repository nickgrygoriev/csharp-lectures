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
            int[] array = new int[] { 8, 1, 5, 3, 6, 2, 5, 4 };

            array.IncreaseSort();

            foreach(int i in array)
                Console.Write("{0} ", i);
            Console.ReadKey();
        }
    }
}
