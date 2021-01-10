using System;

namespace _8.max_counters
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new int[7] { 3, 4, 4, 6, 1, 4, 4 };
            var N = 5;

            var result = solution(N, testArray);
        }

        static int[] solution(int N, int[] A)
        {
            //N counter.
            //12 counter.
            int[] counters = new int[N];
            int maxCounter = counters[0];

            for(var k = 0; k < A.Length; k++)
            {
                if(A[k] > N)
                {
                    for (int i = 0; i < N; i++)
                    {
                        counters[i] = maxCounter;
                    }
                }

                else
                {
                    counters[A[k] - 1] = counters[A[k] - 1] + 1;

                    if (counters[A[k] - 1] > maxCounter)
                        maxCounter = counters[A[k] - 1];
                }
            }

            return counters;
            /*
             *   A[0] = 3
                A[1] = 4
                A[2] = 4
                A[3] = 6
                A[4] = 1
                A[5] = 4
                A[6] = 4


              (0, 0, 1, 0, 0)
            (0, 0, 1, 1, 0)
            (0, 0, 1, 2, 0)
            (2, 2, 2, 2, 2)
            (3, 2, 2, 2, 2)
            (3, 2, 2, 3, 2)
            (3, 2, 2, 4, 2)

             */

        }
    }
}
