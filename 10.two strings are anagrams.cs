using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.two_strings_are_anagrams
{
    class Program
    {
           public static bool verificareAgrm(string nume1, string nume2)
            {
                char[] array1 = nume1.ToCharArray();
                char[] array2 = nume2.ToCharArray();   //array sortat
                Array.Sort(array1);
                Array.Sort(array2);


                for (int i = 0; i < array1.Length; i++) // comparare arrayuri
                    if (array1[i] != array2[i])
                        return false;
                return true;
            }



            static void Main(string[] args)
            {
                Console.WriteLine("scrie cuvintele: ");
                string cuvant1 = Console.ReadLine();
                string cuvant2 = Console.ReadLine();
                if (verificareAgrm(cuvant1.ToLower(), cuvant2.ToLower()))
                    Console.WriteLine("cuvintele sunt angarame.");
                else
                    Console.WriteLine("cuvintele nu sunt angarame.");

                Console.ReadKey();


            }
        }
    }