using System;
using System.Collections.Generic;

namespace _9.missing_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, 3, 6, 4, 1, 2

            var testArray = new int[6] { 1, 3, 6, 4, 1, 2 };

            var result = solution(testArray);



        }

        static int solution(int[] A)
        {
            /*
             * that, given an array A of N integers, returns the smallest positive integer
             * (greater than 0) that does not occur in A.
             */

            HashSet<int> hashSet = new HashSet<int>(A);

            int smallestPositiveInteger = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if(hashSet.Contains(smallestPositiveInteger))
                {
                    smallestPositiveInteger++;
                    continue;
                }    
               
            }

            return smallestPositiveInteger;
        }
    }
}
