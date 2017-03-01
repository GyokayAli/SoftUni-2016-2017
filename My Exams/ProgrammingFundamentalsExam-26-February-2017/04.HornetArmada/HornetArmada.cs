namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var activityDict = new Dictionary<string, long>();
            var legionDict = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = long.Parse(input[0]);
                var legionName = input[1];
                var soldierType = input[2];
                var soldierCount = long.Parse(input[3]);

                if (!activityDict.ContainsKey(legionName))
                {
                    activityDict[legionName] = lastActivity;
                    legionDict[legionName] = new Dictionary<string, long>();
                }

                if (lastActivity > activityDict[legionName])
                {
                    activityDict[legionName] = lastActivity;
                }

                if (!legionDict[legionName].ContainsKey(soldierType))
                {
                    legionDict[legionName][soldierType] = 0;
                }
                legionDict[legionName][soldierType] += soldierCount;
            }

            var format = Console.ReadLine().Split('\\');

            if (format.Length == 1)
            {
                var soldierType = format[0];
                foreach (var legionEntry in activityDict.OrderByDescending(legion => legion.Value))
                {
                    if (legionDict[legionEntry.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legionEntry.Value} : {legionEntry.Key}");
                    }
                }
            }
            else
            {
                var activity = int.Parse(format[0]);
                var soldierType = format[1];

                foreach (var legionEntry in legionDict.Where(legion => legion.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {
                    var legionName = legionEntry.Key;
                    var selectedSoldiersCount = legionDict[legionEntry.Key][soldierType];

                    if (activityDict[legionEntry.Key] < activity)
                    {
                        Console.WriteLine($"{legionName} -> {selectedSoldiersCount}");
                    }
                }
            }
        }
    }
}
