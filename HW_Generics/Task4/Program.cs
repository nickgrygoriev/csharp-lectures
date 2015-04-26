using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Ford> FordCollection = new CarCollection<Ford>();

            FordCollection.AddCar("Shelby", 1965);
            FordCollection.AddCar("Mustang", 1964);

            Console.WriteLine(FordCollection[0].Name);
            Console.WriteLine(FordCollection[1].Name);

            Console.ReadKey();
        }
    }
}
