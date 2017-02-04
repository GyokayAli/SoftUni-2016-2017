namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int start = 0;
            int len = 1;
            int bestEqual = 0;
            int bestLen = 1;

            for (int i = 1; i < numsList.Count; i++)
            {
                if (numsList[i] == numsList[start])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestEqual = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }

            for (int i = bestEqual; i < bestEqual + bestLen; i++)
            {
                Console.Write($"{numsList[i]} ");
            }
        }
    }
}
