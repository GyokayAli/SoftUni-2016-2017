namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountNumbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var occuranceDict = new SortedDictionary<int, int>();

            foreach (var num in numsList)
            {
                if (occuranceDict.ContainsKey(num))
                {
                    occuranceDict[num] += 1;
                }
                else
                {
                    occuranceDict.Add(num, 1);
                }
            }

            foreach (KeyValuePair<int, int> occurance in occuranceDict)
            {
                Console.WriteLine("{0} => {1}", occurance.Key, occurance.Value);
            }
        }
    }
}
