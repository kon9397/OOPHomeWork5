using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(6, 7);
            m.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"[1][2] = {m[1, 2]}");
            Console.WriteLine($"[4][2] = {m[4, 2]}");
            m[0, 0] = 11;

            Console.WriteLine(new string('-', 30));
            m.ChangeSize(7, 6);
            m.Show();

            Console.WriteLine(new string('-', 30));
            m.ShowPartly(1, 0, 4, 4);

            Console.ReadKey();
        }
    }
}
