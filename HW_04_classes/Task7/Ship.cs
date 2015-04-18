using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Ship : Vehicle
    {
        int passengers;
        string port;

        public Ship(int passengers, string port, int speed, int releaseYear, double price) 
            : base(speed, releaseYear, price)
        {
            this.passengers = passengers;
            this.port = port;
        }

        public override void OutputInfo()
        {
            Console.WriteLine("Vehicle: Ship");
            Console.WriteLine("Passengers: {0} \nPort: {1} \nSpeed: {2} \nRelease year: {3} \nPrice: {4}",
                passengers, port, Speed, ReleaseYear, Price);
        }
    }
}
