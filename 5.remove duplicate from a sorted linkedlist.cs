using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.remove_duplicate_from_a_sorted_linkedlist
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Write code to remove duplicates from an unsorted linked list.
            var list = InitList();
            //DisplayList(list);
            for (int i = 0; i < list.Count - 1; i++)
            {

                var firstEl = list.ElementAt(i);
                var secondEl = list.ElementAt(i + 1);

                if (firstEl == secondEl)
                {
                    list.Remove(firstEl);
                }
            }


            DisplayList(list);

            Console.ReadLine();
        }

        private static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
            {
                Console.Write(node + " ");
            }
        }

        private static LinkedList<int> InitList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(10);
            list.AddAfter(list.First, 20);
            list.AddLast(30);
            list.AddLast(30);
            list.AddLast(50);
            return list;
        }

    }
}
