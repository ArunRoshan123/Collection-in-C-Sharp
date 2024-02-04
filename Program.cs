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
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140 ,150 };
            int find = 1000;
            for (int i = 0; i < arr.Length; i++)
            {
                if (find == arr[i])
                {
                    Console.WriteLine("Element present");
                    break;
                }
                else
                {
                    Console.WriteLine("Element not present");
                    break;
                }
            }
        }
    }
}
