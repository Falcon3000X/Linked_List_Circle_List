using Linked_List_Circle_List.Двусвязный_список;
using Linked_List_Circle_List.Кольцевой_список;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Circle_List
{
    class Program
    {
        static void Main(string[] args)
        {

            // --------------------------------------------------------
            // -- Двусвязный список

            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);
            duplexList.Add(6);
            duplexList.Add(7);

            Console.WriteLine("Duplex List");
            foreach (var item in duplexList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");


            duplexList.Delete(4);


            Console.WriteLine("Duplex List");
            foreach (var item in duplexList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            var reverse = duplexList.Reverse();

            Console.WriteLine("Reverse");
            foreach (var item in reverse)
            {
                Console.Write(item + " ");
            }

            //----------------------------------------
            // Кольцевой лист
            Console.WriteLine("\nCircualr list");
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach (var item in circularList)
            {
                Console.Write(item + " ");
            }

            circularList.Delete(3);
            Console.WriteLine();
            foreach (var item in circularList)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
