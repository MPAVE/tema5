using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.reverse_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = InitList();

            DisplayList(lista);

            lista = Listainversata(lista);
            DisplayList(lista);

            Console.ReadKey();


        }
        public static LinkedList<int> InitList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            return list;
        }

        public static LinkedList<int> Listainversata(LinkedList<int> list)
        {
            LinkedList<int> listainversata = new LinkedList<int>();

            foreach (int element in list)
                listainversata.AddFirst(element);
           
            list = listainversata;
            return list;

        }

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
                Console.Write(node + " ");
            Console.WriteLine();
        }

        
    }
}
