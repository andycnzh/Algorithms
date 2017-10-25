using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] unsortedArray = new int[] { 7, 8, 5, 2, 4, 6, 3 };
            foreach (var item in unsortedArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[] sortedArray = new int[unsortedArray.Length];

            //SimpleSort simpleSort = new SimpleSort();
            //sortedArray = simpleSort.Sort(unsortedArray);

            //InsertionSort insertionSort = new InsertionSort();
            //sortedArray = insertionSort.Sort(unsortedArray);

            SelectionSort selectionSort = new SelectionSort();
            sortedArray = selectionSort.Sort(unsortedArray);

            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
