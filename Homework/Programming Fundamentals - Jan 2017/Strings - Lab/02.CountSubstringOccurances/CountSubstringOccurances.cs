namespace _02.CountSubstringOccurances
{
    using System;
    using System.Text.RegularExpressions;
    public class CountSubstringOccurances
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            int occurrences = 0;
            int startingIndex = 0;

            while ((startingIndex = text.IndexOf(substring, startingIndex)) >= 0)
            {
                ++occurrences;
                ++startingIndex;
            }

            Console.WriteLine(occurrences);
        }
    }
}
