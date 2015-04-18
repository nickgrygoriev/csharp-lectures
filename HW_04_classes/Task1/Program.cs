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
            Console.WriteLine("Input length of 1st side:");
            int side1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input length of 2nd side:");
            int side2 = Int32.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(side1, side2);
            Console.WriteLine("Area = {0} \nPerimeter = {1}", r.Area, r.Perimeter);
            Console.ReadKey();
        }
    }
}

