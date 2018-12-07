using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Give_aray_of_ints_total_the_values_even
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 6, 2, 8, 15, 13, 17, 4, 12 };
            int sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                }
            }
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }
    }
}
