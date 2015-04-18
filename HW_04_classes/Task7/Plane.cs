using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Plane : Vehicle
    {
        double height;
        int passengers;

        public Plane(double height, int passengers, int speed, int releaseYear, double price) 
            : base(speed, releaseYear, price)
        {
            this.height = height;
            this.passengers = passengers;
        }

        public override void OutputInfo()
        {
            Console.WriteLine("Vehicle: Plane");
            Console.WriteLine("Maximal height: {0} \nPassengers: {1} \nSpeed: {2} \nRelease year: {3} \nPrice: {4}", 
                height, passengers, Speed, ReleaseYear, Price);
        }
    }
}
