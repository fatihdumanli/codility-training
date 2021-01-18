using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace powers_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Print all positive integer solutions to the equation
                a^3 + b^3 = c^3 + d^3
                Where a, b, c, d are integers between 1 and 1000
            */

            //Solution_1_Brute_Force();
            //Solution_2_Dont_Iterate_All_Ds();
            Solution_3_Using_Hashmap();
            Console.Read();
    
            Console.WriteLine("Hello World!");
        }      

        static void Solution_1_Brute_Force()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            int totalMatches = 0;
            for(int a = 1; a < 1000; a++)
            {
                for(int b = 1; b < 1000; b++)
                {
                    for(int c = 1; c < 1000; c++)
                    {
                        for(int d = 1; d < 1000; d++)
                        {
                            if(Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                            {
                                Console.WriteLine($"Found a match. a: {a} b: {b} c: {c} d: {d}");
                                totalMatches++;
                                break;
                            }

                        }
                    }
                }
            }
            s.Stop();
            Console.WriteLine($"Found {totalMatches} matches in {s.ElapsedMilliseconds / 1000} seconds.");
        }
    
        static void Solution_2_Dont_Iterate_All_Ds()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            int totalMatches = 0;
            for(int a = 1; a < 1000; a++)
            {
                for(int b = 1; b < 1000; b++)
                {
                    for(int c = 1; c < 1000; c++)
                    {
                        var d = Math.Pow((Math.Pow(a, 3) + Math.Pow(b, 3)) - Math.Pow(c, 3), 1/3);

                        if(Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                        {
                               Console.WriteLine($"Found a match. a: {a} b: {b} c: {c} d: {d}");
                               totalMatches++;
                        }
                    }
                }
            }
            s.Stop();
            Console.WriteLine($"Found {totalMatches} matches in {s.ElapsedMilliseconds / 1000} seconds.");
        }

        static void Solution_3_Using_Hashmap()
        {
            //result, pair
            Dictionary<long, int[]> cdPairs = new Dictionary<long, int[]>();

            for(int c = 1; c <= 10; c++)
            {
                for(int d = 1; d <= 10; d++)
                {
                    var result = Convert.ToInt64(Math.Pow(c, 3) + Math.Pow(d, 3));
                    cdPairs.Add(result, new int[2] { c, d});
                    Console.WriteLine($"Putting pair ({c}, {d}) into the hasmap with key {result}");
                }
            }


        }
    }

}
