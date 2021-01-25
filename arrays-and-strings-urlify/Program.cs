using System;

namespace arrays_and_strings_urlify
{
    class Program
    {
        static void Main(string[] args)
        {
            //For a given string, replace all spaces with %20.
            //Stretch the string for a given actual length.
            //INPUT : 'Mr John Smith       ', 13 (spaces counted.)
            //OUTPUT: 'Mr%20John%20Smith'
            var input = "Mr John Smith        ";

            int actualLength = 13;

            var urlfied = URLify(input, actualLength);

            Console.WriteLine($"'{input}' is urlfied: '{urlfied}'");
            Console.Read();
        }

        static string URLify(string phrase, int actualLength)
        {
            int spaceCount = 0;

            for(int i = 0; i < actualLength; i++)
            {
                if (isSpace(phrase[i]))
                    spaceCount++;
            }

            int spacesExcludedLength = actualLength - spaceCount;
            // 3 * '%20'.Length.
            int totalLength = spacesExcludedLength + (3 * spaceCount);

            for (int i = 0; i < phrase.Length; i++)
            {
                if(isSpace(phrase[i]))
                {
                    phrase = phrase.Remove(i, 1);
                    phrase = phrase.Insert(i, "%20");
                }
            }

            return phrase.Substring(0, totalLength);
        }

        static bool isSpace(char c)
        {
            return (int)c == 32;
        }
    }
}
