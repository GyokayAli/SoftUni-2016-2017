﻿namespace _08.MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] values = new int[numbers.Length];

            List<int> scanned = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (scanned.Contains(numbers[i]))
                {
                    values[Array.IndexOf(numbers, numbers[i])]++;
                }
                else
                {
                    values[Array.IndexOf(numbers, numbers[i])]++;
                    scanned.Add(numbers[i]);
                }
            }

            int mostFrequentNum = numbers[Array.IndexOf(values, values.Max())];

            Console.WriteLine(mostFrequentNum);
        }
    }
}