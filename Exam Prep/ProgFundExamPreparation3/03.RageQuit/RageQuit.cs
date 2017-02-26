namespace _03.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();
            var pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);
            int uniqueSymbolsCount = 0;

            var matches = regex.Matches(input);
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var repetitions = int.Parse(match.Groups[2].ToString());
                var symbol = match.Groups[1].ToString();

                for (int i = 0; i < repetitions; i++)
                {
                    sb.Append(symbol);
                }
            }

            uniqueSymbolsCount = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(sb);
        }
    }
}
