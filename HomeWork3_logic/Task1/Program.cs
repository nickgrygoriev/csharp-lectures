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
            Console.WriteLine("Input integer number:");
            int number = Int32.Parse(Console.ReadLine());

            //first method
            if ((number & 1) == 0)
                Console.WriteLine("1st method: The number is even.");
            else
                Console.WriteLine("1st method: The number is odd.");

            //second method
            if (number % 2 == 0)
                Console.WriteLine("2nd method: The number is even.");
            else
                Console.WriteLine("2nd method: The number is odd.");
        }
    }
}
