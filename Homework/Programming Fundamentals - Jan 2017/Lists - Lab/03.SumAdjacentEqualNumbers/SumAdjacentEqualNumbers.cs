namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            int index = 0;
            while (index < numsList.Count - 1)
            {
                if (numsList[index] == numsList[index + 1])
                {
                    numsList[index + 1] += numsList[index];
                    numsList.RemoveAt(index);

                    if (index > 0)
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }
            }

            Console.WriteLine(string.Join(" ", numsList));
        }
    }
}
