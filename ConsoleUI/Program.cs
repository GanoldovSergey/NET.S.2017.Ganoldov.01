using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlg;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 5, 3, 5, 7, -9, 5, 0, -3, -6, 2, -6, 9, 8, -6, 4, -2, 6, 0, 11 };
            QuickSort.Sort(a);
            Console.Write("Sorted array: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            
        }
    }
}
