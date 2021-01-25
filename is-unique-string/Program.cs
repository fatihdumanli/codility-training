using System;

namespace is_unique_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = "fatihf";
            Console.WriteLine($"Does the string {phrase} consist of unique charactes: {isUnique(phrase)}");
            Console.Read();
        }

        static bool isUnique(string phrase)
        {
            bool[] charMap = new bool[128];
            bool isUnique = true;

            foreach(char c in phrase)
            {

                if(charMap[c] == true)
                {
                    isUnique = false;
                }

                else
                {
                    charMap[c] = true;
                }

                if(!isUnique)
                {
                    return false;
                }
            }

            return true;
  
        }
    }
}
