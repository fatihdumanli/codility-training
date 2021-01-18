﻿using System;
using System.Collections.Generic;

namespace substring_permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string shortString = "abbc"; //length of 3
            string longString = "cbabadcbbabbcbabaabccbabc"; //length of 14

            /*
            Permutaion (bba) is found in the range (3, 6)
            Permutaion (bba) is found in the range (7, 10)
            Permutaion (bba) is found in the range (8, 11)
            Permutaion (bba) is found in the range (9, 12)
            */
            permutation(longString, shortString);
            
            Console.WriteLine("Hello World!");
        }

        static void permutation(string longString, string shortString)
        {
            Dictionary<char, int> shortStringHashmap = new Dictionary<char, int>();

            foreach(var c in shortString)
            {
                if(shortStringHashmap.ContainsKey(c))
                {
                    shortStringHashmap[c] = shortStringHashmap[c] + 1;
                }

                else {
                    shortStringHashmap[c] = 1;
                }
            }

            for(int i = 0; i <= longString.Length - shortString.Length; i++)
            {
                var candidate = longString.Substring(i, shortString.Length);
                Dictionary<char, int> candidateHashmap = new Dictionary<char, int>();

               foreach(var c in candidate)
               {
                    if(candidateHashmap.ContainsKey(c))
                    {
                        candidateHashmap[c] = candidateHashmap[c] + 1;
                    }

                    else {
                        candidateHashmap[c] = 1;
                    }
                
                }

                if(candidateHashmap.Count != shortStringHashmap.Count)
                {
                    continue;
                }



                bool isMatch = true;

               foreach(var c in shortStringHashmap)
               {
                   if(!candidateHashmap.ContainsKey(c.Key))
                   {
                       isMatch = false;
                        break;
                   }

                   if(candidateHashmap[c.Key] != c.Value)
                   {
                       isMatch = false;
                        break;
                   }
               }

               if(!isMatch)
                {
                    continue;
                    
                }

               //SAFE ZONE. MEANS A MATCH.
                var x = 2;
                Console.WriteLine($"Permutaion ({shortString}) is found in the range ({i}, {shortString.Length + i})");

            }









        }
        
    }
}
