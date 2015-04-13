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
            Console.WriteLine("Input number:");
            int number = Int32.Parse(Console.ReadLine());

            Check(number);
            Console.ReadKey();
        }

        static void Check(int number)
        {
            if (number >= 0)
                Console.WriteLine("The number is positive");
            else
                Console.WriteLine("The number is negative");

            bool isPrime = true;
            if (number < 2)
                isPrime = false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("The number is prime");
            else
                Console.WriteLine("The number is not prime");

            int[] divisors = { 2, 5, 3, 6, 9 };
            for (int i = 0; i < divisors.Length; i++)
            {
                if (number % divisors[i] == 0)
                    Console.WriteLine("The number is divisible by {0} without remainder", divisors[i]);
                else
                    Console.WriteLine("The number is NOT divisible by {0} without remainder", divisors[i]);
            }
        }
    }
}
