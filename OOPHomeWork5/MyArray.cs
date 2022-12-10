using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork5
{
    internal class MyArray
    {
        int[] array;

        public MyArray(int n)
        {
            array = new int[Math.Abs(n)];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
        }
        public void Min()
        {
            int min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
            }
            Console.WriteLine($"\nMin = {min}");
        }
        public void Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }
            Console.WriteLine($"\nMax = {max}");
        }
        public int Sum()
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum = {sum}");
            return sum;
        }
        public void Average()
        {
            Console.WriteLine($"Average = {Sum() / array.Length}");
        }
        public void Odd()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
