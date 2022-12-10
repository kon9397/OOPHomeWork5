using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(5);

            store.AddArticle(new Article("Redmi", "Foxtrot", 5000), 0);
            store.AddArticle(new Article("iPhone", "Darwin", 28000), 1);
            store.AddArticle(new Article("Shaurma", "StarKebab", 80), 2);
            store.AddArticle(new Article("Gum", "Kopyika", 15), 3);
            store.AddArticle(new Article("Pepsi", "ATB", 25), 4);

            store.Show();
            store.Sort();
            Console.WriteLine("=========");
            store.Show();

            Console.ReadKey();
        }
    }
}
