using System;
using System.Collections.Generic;

namespace _5.perm_missing_elem
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(new int[1] { 0 });
            Console.WriteLine(result);
        }

        static int solution(int[] A)
        {
            HashSet<int> arr = new HashSet<int>();

            foreach(var item in A)
            {
                arr.Add(item);
            }

            for (int i = 1; i <= A.Length + 1; i++)
            {
                var seekFor = i;
                if(!arr.Contains(seekFor))
                {
                    return seekFor;
                }
            }

            return 0;
        }
    }
}
