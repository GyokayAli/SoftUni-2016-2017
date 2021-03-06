﻿namespace _03.ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            var usernames = Console.ReadLine();

            var pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";

            var regex = new Regex(pattern);
            var matchCollection = regex.Matches(usernames);

            var sum = 0;
            var maxSum = 0;
            var first = string.Empty;
            var second = string.Empty;

            for (int i = 1; i < matchCollection.Count; i++)
            {
                sum = matchCollection[i - 1].Length + matchCollection[i].Length;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    first = matchCollection[i - 1].ToString();
                    second = matchCollection[i].ToString();
                }
            }

            Console.WriteLine($"{first}\n{second}");
        }
    }
}
