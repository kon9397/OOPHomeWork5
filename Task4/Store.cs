using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[Math.Abs(size)];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                {
                    return articles[index].Info();
                }
                return "Попытка обращения за пределы массива.";
            }
        }

        public void AddArticle(Article article, int index)
        {
            if(index >= 0 && index < articles.Length)
            {
                articles[index] = article;
            } else
            {
                Console.WriteLine("Попытка записи за пределами массива");
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name == index)
                    {
                        return articles[i].Info();
                    }
                }
                return $"{index} нет в наличии";
            }
        }
        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine(articles[i].Info());
            }
        }

        public void Sort()
        {
            for (int i = 0; i <= articles.Length - 1; i++)
            {
                for (int q = 0; q <= articles.Length - 1; q++)
                {
                    if(articles[i].Price <= articles[q].Price)
                    {
                        Article g = articles[i];
                        articles[i] = articles[q];
                        articles[q] = g;
                    }
                }
            }
        }
    }
}
