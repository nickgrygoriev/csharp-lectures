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
            int A, B;
            Console.WriteLine("Input number A");
            A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input number B");
            B = Int32.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = A + 1; i < B; i++)
                sum += i;
            Console.WriteLine("Sum of numbers beween A and B = {0}", sum);

            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
