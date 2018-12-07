using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.find_if_Array_contains_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 1, 4, 2, 5, 4 };

            
                for (int i = 0; i < array.Length; i++)
                {

                    for (int j = i + 1; j < array.Length; j++)
                    {

                        if (array[i] == array[j])
                        {

                            Console.WriteLine(array[i]);
                        }
                        Console.ReadKey();
                    }

                }
            }
        }
    }

  



