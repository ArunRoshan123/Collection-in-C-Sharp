using System;
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
            List<int> l1 = new List<int>();
            l1.Add(1);
            l1.Add(2);
            l1.Add('a');
            l1.RemoveAt(2);
            l1.Reverse();
            l1.Sort();
            l1[0] = 4;
            for(int i=0;i< l1.Count;i++)
            {
                Console.WriteLine(l1[i]);
            }
            Console.WriteLine(l1.Count());
            Console.WriteLine(l1.Contains(2));
            Console.WriteLine(l1.Capacity);
        }

    }
}
