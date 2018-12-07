using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.factorial_with_recursionanditeration
{
    class Program
    {
        static void Main(string[] args)
        {//itarie
         /* int  fact;
          Console.WriteLine("scrie numarul:");
         int number = Convert.ToInt32(Console.ReadLine());
          fact = number;
          for (int i = number - 1; i >= 1; i--)
          {
              fact = fact * i;
          }
          Console.WriteLine("factorialul este: " + fact);
          Console.ReadLine();

      }*/




            //recursiva
            

            Console.Write(" scrie numarul: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = FactorialCalcu(number);
            Console.WriteLine(" factorialul este:" + fact);
            Console.ReadKey();
        }

        private static int FactorialCalcu(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * FactorialCalcu(n - 1);
        }
    }
}
