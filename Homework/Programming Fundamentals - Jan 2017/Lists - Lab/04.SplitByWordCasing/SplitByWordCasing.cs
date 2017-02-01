namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var wordsList = Console.ReadLine()
                .Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' )
                .ToList();

            var lowerCaseList = new List<string>();
            var mixedCaseList = new List<string>();
            var upperCaseList = new List<string>();

            foreach (var word in wordsList)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if (word.All(ch => char.IsUpper(ch)))
                    {
                        upperCaseList.Add(word);
                    }
                    else if (word.All(ch => char.IsLower(ch)))
                    {
                        lowerCaseList.Add(word);
                    }
                    else
                    {
                        mixedCaseList.Add(word);
                    }
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));
        }
    }
}
