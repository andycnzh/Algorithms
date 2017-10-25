using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class InsertionSort
    {
        /// <summary>
        /// 1. Get a hand of unsorted cards
        /// 2. Set a marker for the sorted section after the first card of the hand
        /// 3. Repeat steps 4 through 6 until the unsorted section is empty
        /// 4.    Select the first unsorted card
        /// 5.    Swap this card to the left until it arrives at the correct sorted position.
        /// 6.    Advance the marker to the right one card
        /// 7. Stop
        /// 
        /// Space efficiency: n+1
        /// Time efficiency: 
        ///     Comparisons: O(n2)
        ///     Copies(Swapped is 3 times copies): O(n2)
        /// </summary>
        /// <param name="unsortedArray">unsorted int array</param>
        /// <returns>sorted int array</returns>
        public int[] Sort(int[] unsortedArray)
        {
            int temp = 0;

            for (int i = 0; i < unsortedArray.Length -1; i++)
            {
                if (unsortedArray[i] > unsortedArray[i + 1])
                {
                    temp = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[i + 1];
                    unsortedArray[i + 1] = temp;
                }

                for (int j = i + 1; j > 0; j--)
                {
                    if (unsortedArray[j] < unsortedArray[j - 1])
                    {
                        temp = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j - 1];
                        unsortedArray[j - 1] = temp;
                    }
                }
            }

            return unsortedArray;
        }
    }
}
