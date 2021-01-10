using System;
using System.Linq;

namespace binary_gap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(15));

        }
        static int solution(int N)
        {
            //find the longest binary gap.

            var binaryRep = Convert.ToString(N, 2);


            //101
            //1001
            //100001

            if (!binaryRep.Contains("0"))
                return 0;

            int counter = binaryRep.Length;

            while(counter > 0)
            {
                var seekFor = string.Format("1{0}1", string.Concat(Enumerable.Repeat("0", counter)));

                if(binaryRep.Contains(seekFor))
                {
                    return counter;
                }

                counter--;
            }

            return counter;
        }
    }
}
