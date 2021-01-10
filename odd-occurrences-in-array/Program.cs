using System;
    using System.Collections.Generic;
using System.Linq;

namespace odd_occurrences_in_array
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(solution(new int[5] { 9, 9, 9, 6, 6 }));

        }

        static int solution(int[] A)
        {
            Dictionary<int, int> occurences = new Dictionary<int, int>();


            for (int i = 0; i < A.Length; i++)
            {
                if(occurences.ContainsKey(A[i]))
                {
                    occurences[A[i]] = occurences[A[i]] + 1;
                }

                else
                {
                    occurences.Add(A[i], 1);
                }
            }


            foreach (var item in occurences)
            {
                if(item.Value % 2 == 1)
                {
                    return item.Key;
                }
            }

            return 0;
        }
    }
}
