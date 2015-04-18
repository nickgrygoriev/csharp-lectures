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
            Point[] points = new Point[5];
            int pointsCounter = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i < 3) { 
                    Console.WriteLine("Input Point{0} name:", i + 1);
                }
                else
                {
                    Console.WriteLine("Input Point{0} name (or leave it empty if you typed enough points):", i + 1);
                }

                string name = Console.ReadLine();
                if (name.Equals("")) { break; }

                Console.WriteLine("Input Point{0} X:", i + 1);
                int x = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input Point{0} Y:", i + 1);
                int y = Int32.Parse(Console.ReadLine());

                points[i] = new Point(x, y, name);
                pointsCounter++;
            }

            switch (pointsCounter)
            {
                case 3:
                    Figure triangle = new Figure(points[0], points[1], points[2]);
                    break;
                case 4:
                    Figure rectangle = new Figure(points[0], points[1], points[2], points[3]);
                    break;
                case 5:
                    Figure pentagon = new Figure(points[0], points[1], points[2], points[3], points[4]);
                    break;
                default:
                    Console.WriteLine("Incorrect number of points");
                    break;
            }
            Console.ReadKey();
        }
    }
}
