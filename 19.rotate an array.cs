using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.rotate_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Rotation(arr, arr.Length, 4);
            Display(arr, arr.Length);
            Console.ReadLine();


        }
        private static void Display (int []arr, int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
        }
        private static void Rotation (int[]arr, int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = arr[0];
                for(int j=1;j<n;j++)
                {
                    arr[j - 1] = arr[j];
                }
                arr[n - 1] = temp;
            }
        }
    }
}
