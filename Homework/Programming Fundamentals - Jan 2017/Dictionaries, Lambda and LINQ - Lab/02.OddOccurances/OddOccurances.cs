namespace _02.OddOccurances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OddOccurances
    {
        static void Main(string[] args)
        {
            var wordsList = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            var wordsDict = new Dictionary<string, int>();

            foreach (var word in wordsList)
            {
                if (!wordsDict.ContainsKey(word))
                {
                    wordsDict[word] = 0;
                }

                wordsDict[word]++;
            }

            var resultsList = new List<string>();

            foreach (var kvp in wordsDict)
            {
                if(kvp.Value % 2 != 0)
                {
                    resultsList.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", resultsList));
        }
    }
}
