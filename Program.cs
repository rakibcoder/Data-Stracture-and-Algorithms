using System;

namespace DataStractureAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linear Search
            int[] intArray = { 1, 2, 3, 50, 90 };
            int index= intArray.LinearSearch(50);
            PrintResult("LinearSearch", index);

            //Binary Search
            int[] intSortArray = { 1, 2, 3, 50, 90,100,110};
            index = intSortArray.BinarySearch(90);
            PrintResult("BinarySearch", index);

            //SelectionSort
            int[] intUnsortArr = { 8, 50, 0, -12, 56, 2, 67, 985, 3 };
            //PrintAllValue("Before sort", intUnsortArr);
            intUnsortArr.SelectionSort();
            PrintAllValue("SelectionSort", intUnsortArr);

        }


        static void PrintResult(string methodName,int result)
        {
            if (result == -1)
            {
                Console.WriteLine($"{methodName} :Input value is not found");
            }
            else
            {
                Console.WriteLine($"{methodName} input Value Index number is {result}");
            }
        }

        static void PrintAllValue(string methodName, int[] intArr)
        {
            string resultString = $"{methodName}: ";

            foreach (var item in intArr)
            {
                resultString += $"{item}\t";
            }
            Console.WriteLine(resultString);
        }
    }
}
