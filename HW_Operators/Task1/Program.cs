using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Block square = new Block(10, 10, 10, 10);
            Block rectangle = new Block(10, 20, 10, 20);
            Block sameSquare = new Block(10, 10, 10, 10);

            Console.WriteLine(square.Equals(rectangle));
            Console.WriteLine(square.Equals(sameSquare));
            Console.WriteLine(rectangle);

            Console.ReadKey();
        }
    }
}
