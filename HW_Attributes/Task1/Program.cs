using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print(new MyClass());

            Console.ReadKey();
        }
    }
}
