using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Article
    {
        string articleName, storeName;
        double price;

        public Article(string articleName, string storeName, double price)
        {
            this.articleName = articleName;
            this.storeName = storeName;
            this.price = price;
        }

        public string ArticleName
        {
            get { return articleName; }
        }

        public string StoreName
        {
            get { return storeName; }
        }

        public double Price
        {
            get { return price; }
        }
    }
}
