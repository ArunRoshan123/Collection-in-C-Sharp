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
            Dictionary<string, int> dick = new Dictionary<string, int>()
            {
                {"Apple", 1},
                { "Orange", 2}
            };
            dick.Add("Arun", 100);
            dick.Add("Roshan", 101);
            dick.Add("AR", 102);
            dick.Add("Dhanush", 103);

            int value;
            if (dick.TryGetValue("AR", out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Key not found.");
            }

            int value1 = dick["Arun"];
            int value2 = dick["Roshan"];

            foreach (KeyValuePair<string, int> p in dick)
            {
                Console.WriteLine("Name is {0} with Score {1}", p.Key, p.Value);
            }

            if (dick.ContainsValue(100))
            {
                Console.WriteLine("Key found");
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            Console.WriteLine(dick.Count());
            Console.WriteLine(value1);
            Console.ReadLine();
        }
    }
}
