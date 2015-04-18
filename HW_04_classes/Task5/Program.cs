using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input account:");
            int account = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input customer:");
            string customer = Console.ReadLine();

            Invoice invoice = new Invoice(account, customer);

            Console.WriteLine("Input article name:");
            invoice.Article = Console.ReadLine(); 
            Console.WriteLine("Input article quantity:");
            invoice.Quantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input price per unit:");
            invoice.PricePerUnit = double.Parse(Console.ReadLine());

            invoice.OrderPrice();
            Console.ReadKey();
        }
    }
}
