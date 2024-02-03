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

            Queue q1 = new Queue();

            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue("Arun");
            q1.Enqueue('A');

            Console.WriteLine("Peek");
            Console.WriteLine(q1.Peek());
            q1.Dequeue();
            foreach (object l1 in q1)
            {
                Console.WriteLine(l1);
            }
        }

    }
}
