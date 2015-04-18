using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter;

            Console.WriteLine("Input operation:");
            Console.WriteLine("1 - Convert from uah to usd, eur or rub");
            Console.WriteLine("2 - Convert usd, eur or rub to uah");
            int action = Int32.Parse(Console.ReadLine());

            switch (action)
            {
                case 1: //uah -> foreign
                    converter = new Converter(23.944, 25.828, 0.477);
                    Console.WriteLine("Input amount of money in uah:");
                    double uahAmount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Input exchange currency (usd, eur or rub):");
                    string exchangeCurrency = Console.ReadLine();
                    converter.ConvertFromUah(uahAmount, exchangeCurrency);
                    break;
                case 2: //foreign -> uah
                    converter = new Converter(21.604, 23.031, 0.406);
                    Console.WriteLine("Input currency of money to convert (usd, eur or rub):");
                    string currency = Console.ReadLine();
                    Console.WriteLine("Input amount of money in {0}:", currency);
                    double amount = double.Parse(Console.ReadLine());
                    converter.ConvertToUah(currency, amount);
                    break;
                default:
                    Console.WriteLine("Incorrect action");
                    break;
            }
            Console.ReadKey();
        }
    }
}
