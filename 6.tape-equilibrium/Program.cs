using System;
using System.Linq;

namespace _6.tape_equilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5] { 3, 1, 2, 4, 3 };
            var result = solution(arr);

            Console.WriteLine("Hello World!");
        }

        static int solution(int[] A)
        {
            //0 < P < N

            var sumLeft = A[0];
            var sumRight = A.Sum() - sumLeft;

            var minDiff = Math.Abs(sumLeft - sumRight);

            for (int i = 1; i < A.Length; i++)
            {
                sumLeft += A[i];
                sumRight -= A[i];

                var diff = Math.Abs(sumLeft - sumRight);

                if (diff < minDiff)
                    minDiff = diff;

            }

            return minDiff;
        }
    }
}
