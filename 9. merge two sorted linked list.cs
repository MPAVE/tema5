using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.merge_two_sorted_linked_list
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            
                LinkedList<int> lista1 = new LinkedList<int>();
                lista1 = InitList(lista1, 3, 5, 6, 8, 9);
                DisplayList(lista1);

                Console.WriteLine("");
                LinkedList<int> lista2 = new LinkedList<int>();
                lista2 = InitList(lista2, 1, 4, 7, 10, 11);
                DisplayList(lista2);

                LinkedList<int> mrglist = new LinkedList<int>();

                int i = 0;
                int j = 0;
                while (i < lista1.Count || j < lista2.Count)
                {
                    if (i == lista1.Count)
                    {
                        mrglist.AddLast(lista2.ElementAt(j));
                        j++;
                        continue;
                    }
                    else if (j == lista1.Count)
                    {
                        mrglist.AddLast(lista1.ElementAt(i));
                        i++;
                        continue;
                    }
                    else if (lista1.ElementAt(i) < lista2.ElementAt(j))
                    {
                        mrglist.AddLast(lista1.ElementAt(i));
                        i++;
                    }
                    else
                    {
                        mrglist.AddLast(lista2.ElementAt(j));
                        j++;
                    }
                }

                Console.WriteLine("");
                Console.Write("Mrg lista : ");
                DisplayList(mrglist);
                Console.ReadKey();
            }

            private static LinkedList<int> InitList(LinkedList<int> list, int no1, int no2, int no3, int no4, int no5)
            {
                list.AddFirst(no1);
                list.AddLast(no2);
                list.AddLast(no3);
                list.AddLast(no4);
                list.AddLast(no5);
                return list;
            }

            private static void DisplayList(LinkedList<int> list)
            {
                foreach (var element in list)
                {
                    Console.Write(element + " ");
                }
            }
        }
    }