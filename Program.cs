using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> l1 = new LinkedList<string>();
            
            l1.AddLast("Arun");
            l1.AddLast("Dhanush");
            l1.AddLast("Sunil");
            l1.AddLast("Mani");

            l1.AddFirst("Prince");

            LinkedListNode<string> node = l1.Find("Arun");

            l1.AddBefore(node, "A R");
            l1.AddAfter(node, "Roshan");

            l1.RemoveLast();
            l1.RemoveFirst();
            l1.Remove("Roshan");

            foreach(string s in l1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
