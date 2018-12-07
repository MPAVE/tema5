using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sum_of_digits_of_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrie numarul:");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = number;
            int suma = 0;
            int rest = 0;

            while(number!=0) // 123 12 1
            {
                rest = number % 10; //3 2 1
                suma = suma + rest; //3, 3 + 2 = 5;,5+1
                number = number / 10; //12,1,0
            }
            Console.WriteLine("suma este:"+suma);
            Console.ReadLine();
        }
    }
}
