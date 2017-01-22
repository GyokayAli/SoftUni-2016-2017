using System;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";

            object objWords = string.Concat(word1, " ", word2);
            string objToString = (string)objWords;

            Console.WriteLine(objToString);
        }
    }
}
