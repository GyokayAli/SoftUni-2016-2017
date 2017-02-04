namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var numsDict = new SortedDictionary<double, int>();

            foreach (var num in numsList)
            {
                if (!numsDict.ContainsKey(num))
                {
                    numsDict[num] = 0;
                }

                numsDict[num]++;
            }

            foreach (var kvp in numsDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
