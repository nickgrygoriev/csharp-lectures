using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ProductComparer : IComparer<Price>
    {
        public int Compare(Price x, Price y)
        {
            string a = x.shopName;
            string b = y.shopName;

            return a.CompareTo(b);
        }
    }
}
