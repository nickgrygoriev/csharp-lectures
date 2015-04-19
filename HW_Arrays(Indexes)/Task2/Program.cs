using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of articles in store");
            int amount = Int32.Parse(Console.ReadLine());
            Store myStore = new Store(amount);
            Article art;

            Console.WriteLine("\nInput index of article to find:");
            int number = Int32.Parse(Console.ReadLine());
            art = myStore[number];
            if (art != null)
                Console.WriteLine("\nName: {0} \nStore: {1} \nPrice: {2}", art.ArticleName, art.StoreName, art.Price);
            else
                Console.WriteLine("Current article does not exist");

            Console.WriteLine("\nInput name of article to find:");
            string name = Console.ReadLine();
            art = myStore[name];
            if (art != null)
                Console.WriteLine("\nName: {0} \nStore: {1} \nPrice: {2}", art.ArticleName, art.StoreName, art.Price);
            else
                Console.WriteLine("Current article does not exist");

            Console.ReadKey();
        }
    }
}
