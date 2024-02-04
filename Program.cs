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
            Stack s1 = new Stack();
            Stack <int> s2= new Stack<int>();

            // using non-genric method
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);
            
            // using genric method
            s2.Push(1);
            s2.Push(2);
            s2.Push(3);
            s2.Push(4);
            s2.Push(5);

            s1.Push("Arun");
            s1.Push("Roshan");
            s1.Push("A R");
            foreach(object o in s1)
            {
                Console.WriteLine(o);
            }
            s1.Pop();
            Console.WriteLine("The top element is");
            Console.WriteLine(s1.Peek());
            Console.WriteLine("Number of elements: " + s1.Count );
            s1.Clear();
            
            Console.WriteLine();
            Console.WriteLine("Generic Method");
            foreach(object o1 in s2)
            {
                Console.WriteLine(o1);
            }
        }

    }
}
