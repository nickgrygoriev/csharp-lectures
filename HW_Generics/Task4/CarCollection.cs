using System;

namespace Task4
{

    class CarCollection<T> where T: Car, new()
    {
        T[] cars;

        public int Length
        {
            get {
                if (cars != null) 
                { 
                    return cars.Length;
                }
                else
                {
                    return 0;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (cars != null && index < cars.Length)
                {
                    return cars[index];
                }
                else
                {
                    Console.WriteLine("No such car");
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void AddCar(string name, int year)
        {
            T car = new T();
            car.Name = name;
            car.Year = year;

            if (cars == null)
            {
                cars = new T[] { car };
            }
            else
            {
                Array.Resize(ref cars, cars.Length + 1);
                cars[cars.Length - 1] = car;
            }
        }
    }
}
