using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SimpleSort
    {
        /// <summary>
        /// 1. Get a list of unsorted numbers
        /// 2. Repeat steps 3 through 6 until the unsorted list is empty
        /// 3.    Compare the unsorted numbers
        /// 4.    Select the smallest unsorted number
        /// 5.    Move this number to the sorted list
        /// 6.    Store a maximum value in the place of the smallest number
        /// 7. Stop
        /// 
        /// Space efficiency: 2n
        /// Time efficiency: 
        ///     Comparisons: O(n2)
        ///     Copies(Swapped is 3 times copies): O(n)
        /// </summary>
        /// <param name="unsortedArray">unsorted int array</param>
        /// <returns>sorted int array</returns>
        public int[] Sort(int[] unsortedArray)
        {
            int temp;
            int[] sortedArray = new int[unsortedArray.Length];

            for (int i = 0; i <= sortedArray.Length - 1; i++)
            {
                temp = 0;

                for (int j = 0; j < unsortedArray.Length - 1; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        if (unsortedArray[temp] > unsortedArray[j + 1])
                        {
                            temp = j + 1;
                        }
                    }
                    else
                    {
                        if (unsortedArray[temp] > unsortedArray[j])
                        {
                            temp = j;
                        }
                    }
                }

                sortedArray[i] = unsortedArray[temp];

                unsortedArray[temp] = int.MaxValue;
            }

            return sortedArray;
        }
    }
}
