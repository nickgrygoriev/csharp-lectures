using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Date
    {
        private int day;
        private int month;
        private int year;
        private DateTime date;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            date = new DateTime(year, month, day);
        }

        public static int operator -(Date date1, Date date2)
        {
            TimeSpan dateDiff = date1.date-date2.date;
            return dateDiff.Days;
        }

        public static Date operator +(Date date1, int numOfDays)
        {
            DateTime newDate = date1.date.AddDays(numOfDays);
            return new Date(newDate.Day, newDate.Month, newDate.Year);
        }

        public override string ToString()
        {
            return String.Format("{0}.{1}.{2}", day, month, year);
        }
    }
}
