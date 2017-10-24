using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSort simpleSort = new SimpleSort();
            int[] unsortedArray = new int[] { 7, 8, 5, 2, 4, 6, 3 };
            foreach (var item in unsortedArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[] sortedArray = simpleSort.Sort(unsortedArray);
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
