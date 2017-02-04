namespace _05.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BombNumbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var bombs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombs[0];
            int bombPower = bombs[1];

            for (int i = 0; i < numsList.Count; i++)
            {
                int start = 0;
                int end = 0;

                if (numsList[i].Equals(bombNumber))
                {
                    if (bombPower - i < 0)
                    {
                        start = i - bombPower;
                    }
                    else
                    {
                        start = 0;
                    }

                    if (i + bombPower > numsList.Count - 1)
                    {
                        end = numsList.Count - 1;
                    }
                    else
                    {
                        end = i + bombPower;
                    }

                    for (int j = end; j >= start; j--)
                    {
                        numsList.Remove(numsList[start]);
                    }

                    i = 0;
                }
            }

            Console.WriteLine(numsList.Sum());
        }
    }
}
