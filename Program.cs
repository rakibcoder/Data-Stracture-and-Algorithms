namespace DataStractureAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            int index= ints.LinearSearch(2);

            Console.WriteLine(index);
        }
    }
}
