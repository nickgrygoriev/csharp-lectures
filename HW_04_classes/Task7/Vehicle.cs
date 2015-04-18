using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Vehicle
    {
        double price;
        int speed, releaseYear;

        public Vehicle(int speed, int releaseYear, double price)
        {
            this.speed = speed;
            this.releaseYear = releaseYear;
            this.price = price;
        }

        public int Speed
        {
            get { return speed; }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
        }

        public double Price
        {
            get { return price; }
        }

        public virtual void OutputInfo()
        {
            Console.WriteLine("Vehicle");
            Console.WriteLine("Speed: {0} \nRelease year: {1} \nPrice: {2}", Speed, ReleaseYear, Price);
        }
    }
}
