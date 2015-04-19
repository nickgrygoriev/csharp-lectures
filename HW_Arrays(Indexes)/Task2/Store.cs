using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Store
    {
        Article[] articles;

        public Store(int articlesAmount)
        {
            articles = new Article[articlesAmount];
            InitArticles();
        }

        public Article this[int index]
        {
            get
            {
                if (index < articles.Length)
                    return articles[index];
                else
                    return null;
            }
            set
            {
                articles[index] = value;
            }
        }

        public Article this[string articleName]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].ArticleName == articleName)
                        return articles[i];
                }
                return null;
            }
        }

        void InitArticles()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine("\nInput name of article {0}:", i+1);
                string name = Console.ReadLine();
                Console.WriteLine("Input name of store:");
                string store = Console.ReadLine();
                Console.WriteLine("Input price of article {0}:", i+1);
                double price = Double.Parse(Console.ReadLine());
                articles[i] = new Article(name, store, price);
            }
        }
    }
}
