using System;

namespace function_with_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

        /*Reading number      
         */

        Console.Write("scrie numarul: ");
        number = Convert.ToInt32(Console.ReadLine());
 
        int f = 0;
        int i = 2;
        while (i <= number / 2)
        {
            if (number % i == 0)
            {
                f = 1;
                break;
            }
         i++;
        }
        if (f == 0)
           Console.WriteLine(number+" este numar prim");
        else
            Console.WriteLine(number + " nu este numar prim");
 
 
        Console.ReadLine();
    }


          
        }
    }