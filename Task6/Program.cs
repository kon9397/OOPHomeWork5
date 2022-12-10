using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            Console.WriteLine("Введите слово");
            string index = Console.ReadLine();
            Console.WriteLine(dictionary[index]);

            Console.ReadKey();
        }
    }
}
