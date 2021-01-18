using System;

namespace distinct_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 1, 7, 5, 9, 2, 12, 3};
            var distinctPairs = DistinctPairCount(arr, 2);
            //Given distinct array (1, 3, 5, 9, 11, 12, 14, 6)
            //Find pairs with given difference k
            Console.WriteLine(distinctPairs);
        }

        static int DistinctPairCount(int[] arr, int k)
        {
            
            //TODO: How to do this with a HashTable (dictionary)
            return 0;
            

        }
    }
}
