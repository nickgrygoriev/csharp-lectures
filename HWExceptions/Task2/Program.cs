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
            Price[] prices = new Price[2];

            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = new Price();

                Console.WriteLine("Input name of product[{0}]:", i + 1);
                prices[i].productName = Console.ReadLine();

                Console.WriteLine("Input shop of product[{0}]:", i + 1);
                prices[i].shopName = Console.ReadLine();

                Console.WriteLine("Input price of product[{0}]:", i + 1);

                try
                {
                    prices[i].productPrice = Double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return;
                }
            }

            Array.Sort(prices, new ProductComparer());

            //foreach (Price price in prices)
            //{
            //    Console.WriteLine(price.shopName);
            //}

            Console.WriteLine("Input name of a shop:");
            string shop = Console.ReadLine();
            bool isFound = false;

            try
            {
                foreach (Price price in prices)
                {
                    if (price.shopName.Equals(shop))
                    {
                        isFound = true;
                        Console.WriteLine("Product: {0}, Price: {1}", price.productName, price.productPrice);
                    }
                }
                if (!isFound)
                {
                    throw new NullShopException("Shop was not found");
                }
            }
            catch (NullShopException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
