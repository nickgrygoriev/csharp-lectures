using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingYears;
            double salary;

            Console.WriteLine("Input number of working years:");
            workingYears = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input worker's salary");
            salary = Double.Parse(Console.ReadLine());

            if (workingYears < 5)
                Console.WriteLine("Premium = {0}", 0.1 * salary);
            if (workingYears >= 5 && workingYears < 10)
                Console.WriteLine("Premium = {0}", 0.15 * salary);
            if (workingYears >= 10 && workingYears < 15)
                Console.WriteLine("Premium = {0}", 0.25 * salary);
            if (workingYears >= 15 && workingYears < 20)
                Console.WriteLine("Premium = {0}", 0.35 * salary);
            if (workingYears >= 20 && workingYears < 25)
                Console.WriteLine("Premium = {0}", 0.45 * salary);
            if (workingYears >= 25)
                Console.WriteLine("Premium = {0}", 0.5 * salary);
            Console.ReadKey();
        }
    }
}
