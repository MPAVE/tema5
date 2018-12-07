using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.array_which_has_a_number_in_the_majority
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 7, 4, 4, 7, 4, 4, 9, 4, 3 };
            int x = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (count == 0)
                {
                    x = arr[i];
                    count = 1;
                    continue;
                }
                else
                {
                    if (x == arr[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            if (count == 0)
            { Console.WriteLine("nu avem"); }

                count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (x == arr[i])
                    {
                        count++;
                    }
                }

            Console.WriteLine(count > arr.Length / 2);
           
           
                Console.ReadLine();
            }
        }
    }
}

