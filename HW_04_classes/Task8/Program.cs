using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введите ключ или нажмите Enter:"); //key = pro || key = exp
            string key = Console.ReadLine();
            DocumentWorker dw;

            switch (key)
            {
                case "pro":
                    dw = new ProDocumentWorker();
                    break;
                case "exp":
                    dw = new ExpertDocumentWorker();
                    break;
                default:
                    dw = new DocumentWorker();
                    break;
            }

            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();

            Console.ReadKey();
        }
    }
}
