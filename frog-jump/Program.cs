using System;

namespace frog_jump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10, 85, 30));
            Console.WriteLine("Hello World!");
        }

        static int solution(int X, int Y, int D)
        {
            //X is the current location
            //Y is the destination
            //D is the distance per jump

            var distance = Y - X;

            double jumps = (double)distance / (double)D;

            var minJumps =  Math.Ceiling(jumps);

            return (int)minJumps;

            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }
}
