using System;
using System.Collections.Generic;

namespace string_check_permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "bccd", b = "cdcb";

            var isPermAnother = isPermutation(a, b);
            Console.WriteLine($"Is {a} a permutation of {b}: {isPermAnother}");
            Console.Read();
        }

        static bool isPermutation(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            int length = a.Length; //or b.Length

            //have same characters, in different order.
            //an example:
            //fatih - thifa

            //use hashmap to find occurences.

            Dictionary<char, int> aOccurences = new Dictionary<char, int>();
            for (int i = 0; i < length; i++)
            {
                if (aOccurences.ContainsKey(a[i]))
                {
                    aOccurences[a[i]]++;
                }

                else
                {
                    aOccurences[a[i]] = 1;
                }
            }

            Dictionary<char, int> bOccurences = new Dictionary<char, int>();
            for (int i = 0; i < length; i++)
            {
                if (bOccurences.ContainsKey(b[i]))
                {
                    bOccurences[b[i]]++;
                }

                else
                {
                    bOccurences[b[i]] = 1;
                }
            }


            //Means at least one dublication of a character, not a permutation.
            if (aOccurences.Count != bOccurences.Count)
                return false;

            foreach(var pair in aOccurences)
            {
                if (!bOccurences.ContainsKey(pair.Key))
                    return false;

                if (bOccurences[pair.Key] != pair.Value)
                    return false;
            }

            return true;
        }
    }
}
