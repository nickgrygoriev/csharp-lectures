using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(4, 160, 1999, 10000.0);
            car.OutputInfo();

            Console.WriteLine();
            Vehicle plane = new Plane(3000, 150, 320, 2005, 120000.0);
            plane.OutputInfo();

            Console.WriteLine();
            Vehicle ship = new Ship(2000, "Liverpool", 44, 1912, 7500000.0);
            ship.OutputInfo();

            Console.ReadKey();
        }
    }
}
