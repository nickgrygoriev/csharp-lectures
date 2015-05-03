using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Doors = 3;
            house.Interior = "Hi-Tech";

            House cloneHouse = house.Clone();
            House deepCloneHouse = house.DeepClone();

            cloneHouse.Doors = 5;
            cloneHouse.Interior = "Vintage"; //interior of house also will be changed
            deepCloneHouse.Doors = 7;
            deepCloneHouse.Interior = "Japan";

            Console.WriteLine("Doors in house: {0}, Interior in house: {1}", house.Doors, house.Interior);
            Console.WriteLine("Doors in clone: {0}, Interior in clone: {1}", cloneHouse.Doors, cloneHouse.Interior);
            Console.WriteLine("Doors in deep clone: {0}, Interior in deep clone: {1}", deepCloneHouse.Doors, deepCloneHouse.Interior);

            Console.ReadKey();

        }
    }
}
