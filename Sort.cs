using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStractureAlgorithms
{
    internal static class Sort
    {
        /// <summary>
        /// Sort int array by using Selection sort Algorithom
        /// </summary>
        /// <param name="intArr"></param>
        public static void SelectionSort(this int[] intArr)
        {
            if (intArr == null)
            {
                throw new ArgumentNullException(nameof(intArr));
            }

            // Outer loop: iterate through each element in the array
            //n-1: not need to sort last element,because last element already sort
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                // Assume the current element is the minimum
                int minValue = intArr[i];
                int minIndex = i;

                // Inner loop: find the minimum element in the remaining unsorted part
                for (int j = i + 1; j < intArr.Length; j++)
                {
                    if (minValue > intArr[j])
                    {
                        // Update the minimum value and index if a smaller element is found
                        minValue = intArr[j];
                        minIndex = j;
                    }
                }

                // Swap the minimum element with the first element in the unsorted part
                if (minIndex != i)
                {
                    intArr[minIndex] = intArr[i];
                    intArr[i] = minValue;
                }
            }
        }
    }
}
