namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LogsAggregator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var logDictionary = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var logArr = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var ip = logArr[0];
                var user = logArr[1];
                var duration = int.Parse(logArr[2]);

                if (!logDictionary.ContainsKey(user))
                {
                    logDictionary[user] = new Dictionary<string, int>() { { ip, duration } };
                }
                else
                {
                    if (!logDictionary[user].ContainsKey(ip))
                    {
                        logDictionary[user][ip] = 0;
                    }
                    logDictionary[user][ip] += duration;
                }
            }

            foreach (var log in logDictionary.OrderBy(x => x.Key))
            {
                var user = log.Key;
                var userTotalDuration = log.Value.Values.Sum();
                var userIps = log.Value.Keys.ToArray().OrderBy(x => x);

                Console.Write($"{user}: {userTotalDuration} [" + string.Join(", ", userIps) + "]");
                Console.WriteLine();
            }
        }
    }
}
