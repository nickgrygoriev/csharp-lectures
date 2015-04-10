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
            Console.WriteLine("Please input integer number from 0 to 100:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 100)
            {
                if (number <= 14)
                    Console.WriteLine("Your number is in range from 0 to 14");
                else if (number <= 35)
                    Console.WriteLine("Your number is in range from 15 to 35");
                else if (number <= 50)
                    Console.WriteLine("Your number is in range from 36 to 50");
                else
                    Console.WriteLine("Your number is in range from 51 to 100");
            }
            else
            {
                Console.WriteLine("Your number is not included in any range");
            }
                
            Console.ReadKey();
        }
    }
}
