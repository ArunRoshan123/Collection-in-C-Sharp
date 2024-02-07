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
            var names = new SortedSet<string>() { "ARUN", "DHANUSH", "SUNIL", "MANI", "ARUN"};

            names.Add("Arun");
            names.Add("Dhanush");
            names.Add("Sunil");
            names.Add("Mani");
            names.Remove("Mani");
            foreach(var name in names)
            {
                Console.WriteLine(name);    
            }
        }
    }
}
