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
            Date date1 = new Date(20, 4, 2014);
            Date date2 = new Date(30, 5, 2015);

            Console.WriteLine("Number of days between {0} and {1}: {2}", date1, date2, date2 - date1);

            int addDays = 365;
            Date addDate = date2 + addDays;

            Console.WriteLine("{0} + {1} days: {2}", date2, addDays, addDate);
            Console.ReadKey();
        }
    }
}
