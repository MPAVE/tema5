using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, suma = 0, temp;
            Console.Write("scrie numarul ");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                suma = suma + (r * r * r);
                n = n / 10;
            }
            if (temp == suma)
                Console.Write("este un numar armstrong.");
            else
                Console.Write("nu este un numar armstrong.");

            Console.ReadLine();
        }
    }
}
