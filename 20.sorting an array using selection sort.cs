using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.sorting_an_array_using_selection_sort
{
    class Program
    {
        public static void Sortare(int[] arr)
        {

            int minindex, temp;

            for (int i = 0; i < arr.Length-1; i++)
            {
                minindex = i;
                for (int j = i + 1; j < arr.Length; j++)
                
                    if (arr[j] < arr[minindex])
                        minindex = j;
                    if (minindex != i)
                    {
                        temp = arr[i];
                        arr[i] = arr[minindex];
                        arr[minindex] = temp;
                    }  
            }
        }

            public static void Display(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write( item+" ");
                
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 1, 6, 3, 7, 5, 9, 8 };
            
            Sortare(arr);
            Console.WriteLine("arrayul sortat este:");
            Display(arr);
            Console.ReadKey();
        }
        

        }

    }

