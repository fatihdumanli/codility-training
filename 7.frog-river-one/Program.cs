using System;
using System.Collections.Generic;

namespace _7.frog_river_one
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[8] { 1, 3, 1, 4, 2, 3, 5, 4 };
            var X = 5;

            var result = solution(X, arr);

            Console.WriteLine("Hello World!");
        }
        static int solution(int X, int[] A)
        {

            List<bool> needLeafAtArray = new List<bool>();

            for (int i = 0; i < X; i++)
            {
                needLeafAtArray.Add(false);
            }

            for (int k = 0; k < A.Length; k++)
            {
                needLeafAtArray[A[k] - 1] = true;
                
                if (!needLeafAtArray.Contains(false))
                {
                    return k;
                }

            }

            return -1;           
        }
    }
}
