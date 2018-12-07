using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.fct_print_nth_number_in_Fibonacci_series
{
    class Program
    {

        public static int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("How Many Element You Want To Print ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int F = Fibonacci(i);
                Console.WriteLine(F);
            }
            Console.ReadLine();
        }
    }
}


   
