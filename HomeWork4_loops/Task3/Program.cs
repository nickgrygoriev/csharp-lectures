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
            int side = 5;

            Console.WriteLine("Rectangle:");
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < 2*side; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Right triangle:");
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Equilateral triangle:");
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Rhombus:");
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            for (int i = side - 1; i > 0; i--)
            {
                for (int j = 0; j < side - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
                Console.ReadKey();
        }
    }
}
