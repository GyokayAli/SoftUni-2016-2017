namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            var positivesList = new List<int>();

            foreach (var num in numsList)
            {
                if (num > 0)
                {
                    positivesList.Add(num);
                }
            }

            Console.WriteLine(positivesList.Count == 0 ? "empty" : string.Join(" ", positivesList));
        }
    }
}
