using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SelectionSort
    {
        /// <summary>
        /// 1. Get a list of unsorted numbers
        /// 2. Set a marker for the unsorted section at the front of the list
        /// 3. Repeat steps 4 - 6 until one number remains in the unsorted section
        /// 4.     Compare all unsorted numbers in order to select the smallest one
        /// 5.     Swap this number with the first number in the unsorted section
        /// 6.     Advance the marker to the right one position
        /// 7. Stop
        /// 
        /// Space efficiency: n+1
        /// Time efficiency: 
        ///     Comparisons: O(n^2)
        ///     Copies(Swapped is 3 times copies): O(n)
        /// </summary>
        /// <param name="unsortedArray"></param>
        /// <returns></returns>
        public int[] Sort(int[] unsortedArray)
        {
            int smallestPosition = 0;
            int temp = 0;
            for (int i = 0; i < unsortedArray.Length - 1; i++)
            {
                for (int j = i; j < unsortedArray.Length - 1; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        if (unsortedArray[smallestPosition] > unsortedArray[j + 1])
                        {
                            smallestPosition = j + 1;
                        }
                    }
                    else
                    {
                        if (unsortedArray[smallestPosition] > unsortedArray[j])
                        {
                            smallestPosition = j;
                        }
                    }
                }

                temp = unsortedArray[i];
                unsortedArray[i] = unsortedArray[smallestPosition];
                unsortedArray[smallestPosition] = temp;
            }

            return unsortedArray;
        }
    }
}
