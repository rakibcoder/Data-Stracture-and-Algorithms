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
        /// Get Search Value Indexnumber from Array By Using Linear Search Algorithms
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
                if (intArr[index] == searchValue)
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
