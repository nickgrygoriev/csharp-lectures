using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ConvertFromUah(double uah, string currency)
        {
            switch (currency)
            {
                case "usd":
                    Console.WriteLine("{0} UAH = {1} USD", uah, uah / usd);
                    break;
                case "eur":
                    Console.WriteLine("{0} UAH = {1} EUR", uah, uah / eur);
                    break;
                case "rub":
                    Console.WriteLine("{0} UAH = {1} RUB", uah, uah / rub);
                    break;
                default:
                    Console.WriteLine("Unknown currency");
                    break;
            }
        }

        public void ConvertToUah(string currency, double money)
        {
            switch (currency)
            {
                case "usd":
                    Console.WriteLine("{0} USD = {1} UAH", money, money * usd);
                    break;
                case "eur":
                    Console.WriteLine("{0} EUR = {1} UAH", money, money * eur);
                    break;
                case "rub":
                    Console.WriteLine("{0} RUB = {1} UAH", money, money * rub);
                    break;
                default:
                    Console.WriteLine("Unknown currency");
                    break;
            }
        }

    }
}
