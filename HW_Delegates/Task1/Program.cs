using System;

namespace Task1
{
    public delegate int Operation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Operation add = (x, y) => { return x + y; };
            Operation sub = (x, y) => { return x - y; };
            Operation mul = (x, y) => { return x * y; };
            Operation div = (x, y) =>
            {
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    return x / y;
                }
            };

            Console.WriteLine("Input first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input operation (add/sub/mul/div)");
            string action = Console.ReadLine();

            int res;
            switch (action)
            {
                case "add":
                    res = add(a, b);
                    Console.WriteLine("{0} + {1} = {2}", a, b, res);
                    break;
                case "sub":
                    res = sub(a, b);
                    Console.WriteLine("{0} - {1} = {2}", a, b, res);
                    break;
                case "mul":
                    res = mul(a, b);
                    Console.WriteLine("{0} * {1} = {2}", a, b, res);
                    break;
                case "div":
                    try
                    {
                        res = div(a, b);
                        Console.WriteLine("{0} / {1} = {2}", a, b, res);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Division by zero error!");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }

            Console.ReadKey();
        }
    }
}