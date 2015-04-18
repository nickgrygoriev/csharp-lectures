using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Car : Vehicle
    {
        int numOfDoors;

        public Car(int numOfDoors, int speed, int releaseYear, double price) 
            : base(speed, releaseYear, price)
        {
            this.numOfDoors = numOfDoors;
        }

        public override void OutputInfo()
        {
            Console.WriteLine("Vehicle: Car");
            Console.WriteLine("Number of doors: {0} \nSpeed: {1} \nRelease year: {2} \nPrice: {3}", 
                numOfDoors, Speed, ReleaseYear, Price);
        }
    }
}
