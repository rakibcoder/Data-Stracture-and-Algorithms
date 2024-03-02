using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStractureAlgorithms
{
    internal static class Search
    {
        /// <summary>
        /// Get Search Value Index number from Array By Using Linear Search Algorithms
        /// </summary>
        /// <param name="intArr">input integer array</param>
        /// <param name="searchValue">which value search into array</param>
        /// <returns>if searchValue is found then return searchValue index number
        /// or return -1</returns>
        /// <exception cref="ArgumentNullException">Array is null</exception>
        public static int LinearSearch(this int[] intArr,int searchValue)
        {
            int index;

            if (intArr==null)
            {
                throw new ArgumentNullException(nameof(intArr));
            }
            
            for (index=0;index<intArr.Length;index++)
            {
                //if array index value is equal to search value
                if (intArr[index] == searchValue)
                {
                    return index;
                }
            }

            return -1;
        }

        /// <summary>
        /// Get Search Value Index number from SortArray By Using Binary Search Algorithms
        /// </summary>
        /// <param name="intSortArr">input integer array</param>
        /// <param name="searchValue">which value search into array</param>
        /// <returns>if searchValue is found then return searchValue index number
        /// or return -1</returns>
        /// <exception cref="ArgumentNullException">Array is null</exception>
        public static int BinarySearch(this int[] intSortArr,int searchValue)
        {
            int left, right,mid;

            if (intSortArr == null)
            {
                throw new ArgumentNullException(nameof (intSortArr));
            }

            left = 0;
            right=intSortArr.Length;

            while (left<=right)
            {
                //find middle
                mid = (left + right) / 2;

                
                if (intSortArr[mid]==searchValue)
                {
                    //if index value is equal to search value
                    return mid;
                }else if (intSortArr[mid] <= searchValue)
                {
                    //if index value is equal or less then search value
                    left = mid + 1;
                }
                else
                {
                    //if index value is geater then search value
                    right = mid - 1;
                }
            }

            return -1;
        }

    }
}
