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
            SortedDictionary<string,string> l1 = new SortedDictionary<string,string>();
            
            l1.Add("1","Arun");
            l1.Add("5","Prince");        
            l1.Add("3","Sunil");
            l1.Add("2","Dhanush");
            l1.Add("4","Mani");
            
            l1.Remove("4");

            foreach(KeyValuePair<string,string> s in l1)
            {
                Console.WriteLine(s.Key+ " "+s.Value);
            }
        }
    }
}
