using System;
using System.Collections.Generic;

namespace _10.perm_check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int solution(int[] A)
        {
            HashSet<int> hashSet = new HashSet<int>(A);

            for(int i = 1; i <= A.Length; i++)
            {
                if (!hashSet.Contains(i))
                    return 0;
            }

            return 1;
        }
    }
}
