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
            Console.WriteLine("Input type of file (XML, TXT or DOC): ");
            string file = Console.ReadLine();

            AbstractHandler handler = null;

            switch (file)
            {
                case "XML":
                    handler = new XMLHandler();
                    break;
                case "TXT":
                    handler = new TXTHandler();
                    break;
                case "DOC":
                    handler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Unknown file format");
                    break;
            }

            if (handler != null)
            {
                handler.Create();
                handler.Open();
                handler.Change();
                handler.Save();
            }

            Console.ReadKey();
        }
    }
}
