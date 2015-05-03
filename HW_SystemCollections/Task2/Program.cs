using System;
using System.Collections;
using System.Collections.Specialized;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyComparer myComp = new MyComparer();
            OrderedDictionary customers = new OrderedDictionary(myComp);

            customers.Add(new Product() { Name = "Potato", Barcode = 11 }, "John");
            customers.Add(new Product() { Name = "Carrot", Barcode = 22 }, "Lisa");
            customers.Add(new Product() { Name = "Apple", Barcode = 33 }, "Bill"); 
            customers.Add(new Product() { Name = "Cabbage", Barcode = 44 }, "Nick");
            //customers.Add(new Product() { Name = "Cucumber", Barcode = 33 }, "Bill"); //Barcode already exists

            foreach (DictionaryEntry entry in customers)
            {
                Console.WriteLine(entry.Value);
            }

            Console.ReadKey();
        }
    }

    class MyComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            Product prod1 = x as Product;
            Product prod2 = y as Product;
            return prod1.Barcode == prod2.Barcode;
        }

        public int GetHashCode(object obj)
        {
            return (obj as Product).Barcode;
        }
    }

    class Product
    {
        public int Barcode { get; set; }
        public string Name { get; set; }
    }
}
