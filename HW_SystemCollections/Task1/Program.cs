using System;
using System.Collections.Specialized;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection customers = new NameValueCollection();

            customers.Add("John", "Potato");
            customers.Add("Lisa", "Carrot");
            customers.Add("Bill", "Potato");
            customers.Add("Nick", "Cabbage");
            customers.Add("John", "Apple");
            customers.Add("Bill", "Plum");
            customers.Add("Nick", "Apple");
            customers.Add("Lisa", "Apple");

            string customerName = "John";
            string productName = "Apple";

            Console.WriteLine("Products of {0}:", customerName);
            Console.WriteLine(customers[customerName]);

            Console.WriteLine("\nCustomers that buy {0}:", productName);
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Contains(productName))
                {
                    Console.WriteLine(customers.GetKey(i));
                }
            }

            Console.ReadKey();
        }
    }
}
