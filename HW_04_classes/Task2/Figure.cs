using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Figure
    {
        Point A, B, C, D, E;

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            Console.WriteLine("Triangle");
            PerimeterCalculator();
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            Console.WriteLine("Rectangle");
            PerimeterCalculator();
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            Console.WriteLine("Pentagon");
            PerimeterCalculator();
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }

        void PerimeterCalculator()
        {
            double perimeter = LengthSide(A, B) + LengthSide(B, C);
            if (E == null)
            {
                if (D == null)
                {
                    perimeter += LengthSide(C, A);
                }
                else
                {
                    perimeter += LengthSide(C, D) + LengthSide(D, A);
                }
            }
            else
            {
                perimeter += LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
            }
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}
