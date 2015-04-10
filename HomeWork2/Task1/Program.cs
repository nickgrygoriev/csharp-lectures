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
            int operand1 = 16;
            int operand2 = 4;
            string sign;

            Console.WriteLine("Input operation (+ - * /):");
            sign = Console.ReadLine();

            switch (sign){
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                        Console.WriteLine("Error! Division by zero!");
                    else
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                    break;
                default:
                    Console.WriteLine("Illegal sign");
                    break;
            }
            Console.ReadKey();
        }
    }
}
