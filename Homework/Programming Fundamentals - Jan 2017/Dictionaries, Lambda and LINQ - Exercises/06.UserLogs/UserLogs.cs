namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UserLogs
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var logDict = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] separators = { "message", "=" };

                var ipAndUsername = input
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string ip = ipAndUsername[1];
                string username = ipAndUsername[3];

                if (!logDict.ContainsKey(username))
                {
                    logDict[username] = new Dictionary<string, int> { { ip, 1 } };
                }
                else
                {
                    if (!logDict[username].ContainsKey(ip))
                    {
                        logDict[username][ip] = 0;
                    }
                    logDict[username][ip]++;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in logDict)
            {
                var username = kvp.Key;
                Console.WriteLine($"{username}:");

                foreach (var log in logDict[kvp.Key])
                {
                    var ip = log.Key;
                    var msgCount = log.Value;

                    if (ip != kvp.Value.Keys.Last())
                    {
                        Console.Write($"{ip}=> {msgCount}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip}=> {msgCount}.");
                    }
                }
            }
        }
    }
}