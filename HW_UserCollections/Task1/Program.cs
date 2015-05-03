using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Month[] monthArray = new Month[12]{
                new Month{Name = "January", Number = 1, DaysQuantity = 31},
                new Month{Name = "February", Number = 2, DaysQuantity = 28},
                new Month{Name = "March", Number = 3, DaysQuantity = 31},
                new Month{Name = "April", Number = 4, DaysQuantity = 30},
                new Month{Name = "May", Number = 5, DaysQuantity = 31},
                new Month{Name = "June", Number = 6, DaysQuantity = 30},
                new Month{Name = "July", Number = 7, DaysQuantity = 31},
                new Month{Name = "August", Number = 8, DaysQuantity = 31},
                new Month{Name = "September", Number = 9, DaysQuantity = 30},
                new Month{Name = "October", Number = 10, DaysQuantity = 31},
                new Month{Name = "November", Number = 11, DaysQuantity = 30},
                new Month{Name = "December", Number = 12, DaysQuantity = 31}
            };

            MonthCollection monthes = new MonthCollection(monthArray);

            Month fifthMonth = monthes[5];
            Console.WriteLine("{0} {1} {2}", fifthMonth.Name, fifthMonth.Number, fifthMonth.DaysQuantity);
            
            Console.WriteLine();
            foreach (Month month in monthes.GetByDays(30)) // choose all monthes with 30 days
            {
                Console.WriteLine("{0} {1} {2}", month.Name, month.Number, month.DaysQuantity);
            }

            Console.WriteLine();
            foreach (Month month in monthes.GetByDays(31)) // choose all monthes with 31 days
            {
                Console.WriteLine("{0} {1} {2}", month.Name, month.Number, month.DaysQuantity);
            }

            Console.ReadKey();
        }
    }
}
