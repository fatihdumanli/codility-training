using System;

namespace cyclic_rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            solution(new int[5] { 3, 8, 9, 7, 6 }, 3);
            Console.WriteLine("Hello World!");

        }

        static int[] solution(int[] A, int K)
        {
            int[] B = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                var newIndex = (i + K) % A.Length;
                B[newIndex] = A[i];
            }

            return B;
        }
    }
}
