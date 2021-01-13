using System;

namespace _11.count_div
{
    class Program
    {
        static void Main(string[] args)
        {
            //A = 11, B = 345, K = 17
            var a = 11;
            var b = 345;
            var k = 17;

            var mod = 11 % 17;
            var result = solution(a, b, k);

            Console.WriteLine("Hello World!");
        }

        static int solution(int A, int B, int K)
        {

            /*
             * that, given three integers A, B and K, 
             * returns the number of integers within the range [A..B] that are divisible by K.
             */

            // 11 % 17 == 0

            var result = (B - A) / K;
            if(A % K == 0)
            {
                result++;
            }

            return result;
        }
    }
}
