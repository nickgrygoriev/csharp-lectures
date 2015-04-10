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
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;

            String a = "\nмоя строка 1"; //перенос строки
            String b = "\tмоя строка 2"; //табуляция
            String c = "\aмоя строка 3"; //системный звук (alert)

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
