using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(12);

            myArray.Min();
            myArray.Max();
            myArray.Average();
            myArray.Odd();

            Console.ReadKey();
        }
    }
}
