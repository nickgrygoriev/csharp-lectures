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
            Console.WriteLine("Input operand A:");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input operand B:");
            int B = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input operation sign:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Add(A, B);
                    break;
                case "-":
                    Sub(A, B);
                    break;
                case "*":
                    Mul(A, B);
                    break;
                case "/":
                    Div(A, B);
                    break;
                default:
                    Console.WriteLine("Incorrect sign");
                    break;
            }
            Console.ReadKey();
        }

        static void Add(int A, int B)
        {
            Console.WriteLine("A + B = {0}", A + B);
        }

        static void Sub(int A, int B)
        {
            Console.WriteLine("A - B = {0}", A - B);
        }

        static void Mul(int A, int B)
        {
            Console.WriteLine("A * B = {0}", A * B);
        }

        static void Div(int A, int B)
        {
            if (B == 0)
            {
                Console.WriteLine("Error! Division by zero");
                return;
            }
            Console.WriteLine("A / B = {0}", A / B);
        }
    }
}
