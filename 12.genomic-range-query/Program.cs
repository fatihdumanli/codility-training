using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.genomic_range_query
{
    class Program
    {
        static void Main(string[] args)
        {

            var P = new int[] { 2, 5, 0 };
            var q = new int[] { 4, 5, 6 };
            var S = "TATGCCTATGTCTATGCCTTTAGCTATGCTAATCTGCTTTGTTCATCAGCCTAAGCTTAAGCCTT";

            var result = solution(S, P, q);
            /*
             * Nucleotides of types A, C, G and T have impact factors of 1, 2, 3 and 4, respectively.
             * 
             * For example, consider string S = CAGCCTA and arrays P, Q such that:
                P[0] = 2    Q[0] = 4  G, C (3 and 2) so the answer is 2
                P[1] = 5    Q[1] = 5  T, T (5 and 5) so the answer is 4
                P[2] = 0    Q[2] = 6  C, A (2 and 1) so the answer is 1

             */
            Console.WriteLine("Hello World!");
        }

        static int[] solution(string S, int[] P, int[] Q)
        {
            if (P.Length != Q.Length)
                throw new ArgumentException("The arrays P and Q must have same length");

            int[] ascii = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                ascii[i] = (int)S[i];
            }

            Array.Sort(ascii);


            var resultArray = new int[P.Length];
           
            //C(A)GCCT(A)
            for (int i = 0; i < P.Length; i++)
            {
                var start = P[i];
                var end = Q[i];
            }


    

            return resultArray;




            /*
               * ASCII TABLE
               * A: 65
               * C: 67
               * G: 71
               * T: 84
               */
            //int minAscii = 84;

            //for (int k = queryP; k <= queryQ; k++)
            //{
            //    var ascii = (int)S[k];

            //    if (ascii < minAscii)
            //        minAscii = ascii;

            //    if (ascii == 65) //A
            //    {
            //        minAscii = 65;
            //        break;
            //    }

            //}


            //switch (minAscii)
            //{
            //    case 65:
            //        resultArray[i] = 1; break;

            //    case 67:
            //        resultArray[i] = 2; break;
            //    case 71:
            //        resultArray[i] = 3; break;
            //    case 84:
            //        resultArray[i] = 4; break;

            //}
            //return resultArray;
        }
    }
}
