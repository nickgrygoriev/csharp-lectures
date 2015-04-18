using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Invoice
    {
        readonly int account;
        readonly string customer;

        string article;
        int quantity;
        double pricePerUnit;

        public Invoice(int account, string customer)
        {
            this.account = account;
            this.customer = customer;
        }

        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double PricePerUnit
        {
            get { return pricePerUnit; }
            set { pricePerUnit = value; }
        }

        public void OrderPrice()
        {
            Console.WriteLine("\nYour order is: {0}, {1} units, {2}$ per unit", Article, Quantity, PricePerUnit);
            Console.WriteLine("Price without taxes: {0}", Quantity * PricePerUnit);
            Console.WriteLine("Price with taxes: {0}", Quantity * PricePerUnit + Quantity * PricePerUnit * 0.2);
        }
    }
}
