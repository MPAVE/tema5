using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti cuvantul:");
            string a = Console.ReadLine();
            char[] arr1 = a.ToCharArray();
            Array.Reverse(arr1);

           string b = new string(arr1);

            if(a.Equals(b))
            {
                Console.WriteLine("acesta este palindrom");
            }
            else
            {
                Console.WriteLine("acesta nu este palindrom");
            }
            Console.ReadLine();
        }
    }
}
