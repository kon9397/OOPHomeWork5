using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Article
    {
        double price;

        public string Name { get; private set; }
        public string Shop { get; set; }

        public double Price
        {
            set
            {
                if(value >= 0)
                {
                    price = value;
                } 
                else
                {
                    Console.WriteLine("Стоимость не может быть отрицательной");
                }
            }
            get { return price; }
        }

        public Article(string name)
        {
            Name = name;
        }

        public Article(string name, string shop, double price)
        {
            Name = name;
            Shop = shop;
            Price = price;
        }

        public string Info()
        {
            return $"{Name} из {Shop} стоит {Price} грн.";
        }
    }
}
