using System;

namespace DataStractureAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linear Search
            int[] intArray = { 1, 2, 3, 50, 90 };
            int index= intArray.LinearSearch(4);
            PrintResult("LinearSearch", index);

            //Binary Search
            int[] intSortArray = { 1, 2, 3, 50, 90,100,110};
            index = intSortArray.BinarySearch(90);
            PrintResult("BinarySearch", index);

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
    }
}
