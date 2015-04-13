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
            Console.WriteLine("Input amount of money:");
            double money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input value of 1 unit of inputted currency: 1 unit = ");
            double moneyUnit = Double.Parse(Console.ReadLine());

            double convertedMoney = Convert(money, moneyUnit);
            Console.WriteLine("After exchange {0} -> {1} money", money, convertedMoney);
            Console.ReadKey();
        }

        static double Convert(double money, double moneyUnit)
        {
            return money * moneyUnit;
        }
    }
}
