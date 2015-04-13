using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of clients:");
            int N = Int32.Parse(Console.ReadLine());

            int ways = 1;
            do
            {
                ways *= N--;
            } while (N > 0);

            Console.WriteLine("Number of delivery options: {0}", ways);
            Console.ReadKey();
        }
    }
}
