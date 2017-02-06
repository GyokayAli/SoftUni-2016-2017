namespace _10.SerbianUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    class SerbianUnleashed
    {
        static void Main(string[] args)
        {
            const string pattern = @"(.*?) @(.*?) (\d+) (\d+)";
            var concertsDict = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                if(!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var match = Regex.Match(input, pattern);
                string singerName = match.Groups[1].Value;
                string venueName = match.Groups[2].Value;
                int ticketPrice = int.Parse(match.Groups[3].Value);
                int ticketCount = int.Parse(match.Groups[4].Value);
                var totalIncome = ticketCount * ticketPrice;

                if (!concertsDict.ContainsKey(venueName))
                {
                    concertsDict[venueName] = new Dictionary<string, long> { { singerName, totalIncome} };
                }
                else
                {
                    if (!concertsDict[venueName].ContainsKey(singerName))
                    {
                        concertsDict[venueName][singerName] = 0;
                    }

                    concertsDict[venueName][singerName] += totalIncome;
                }

                input = Console.ReadLine();
            }

            foreach (var concert in concertsDict)
            {
                var venue = concert.Key;
                Console.WriteLine(venue);

                foreach (var singer in concert.Value.OrderByDescending(x => x.Value))
                {
                    var singerName = singer.Key;
                    var singerSalary = singer.Value;
                    Console.WriteLine($"#  {singerName} -> {singerSalary}");
                }
            }
        }
    }
}
