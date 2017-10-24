using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSort
{
    class SimpleSort
    {
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
