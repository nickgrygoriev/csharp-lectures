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
            int rows = 5, cols = 5;
            MyMatrix matrix = new MyMatrix(rows, cols);

            matrix.Output();

            matrix.ChangeSize(3, 3);
            Console.WriteLine();
            matrix.Output();

            matrix.ChangeSize(5, 6);
            Console.WriteLine();
            matrix.Output();

            Console.ReadKey();
        }
    }
}
