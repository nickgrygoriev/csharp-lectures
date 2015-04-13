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
            int x = 5, y = 10, z = 15; 

            x += y >> x++ * z;
            Console.WriteLine("x = " + x);

            z = ++x & y * 5;
            Console.WriteLine("z = " + z);

            x = 5;
            z = 15;
            y /= x + 5 | z;
            Console.WriteLine("y = " + y);

            y = 10;
            z = x++ & y * 5;
            Console.WriteLine("z = " + z);

            x = 5;
            z = 15;
            x = y << x++ ^ z;
            Console.WriteLine("x = " + x);
            Console.ReadKey();
        }
    }
}
