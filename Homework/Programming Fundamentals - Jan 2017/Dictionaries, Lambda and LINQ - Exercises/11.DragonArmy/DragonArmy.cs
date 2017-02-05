namespace _11.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DragonArmy
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var type = tokens[0];
                var name = tokens[1];

                var damage = tokens[2] != "null" ? decimal.Parse(tokens[2]) : 45;
                var health = tokens[3] != "null" ? decimal.Parse(tokens[3]) : 250;
                var armor = tokens[4] != "null" ? decimal.Parse(tokens[4]) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { damage, health, armor };
            }

            foreach (var type in dragons)
            {
                var typeName = type.Key;
                var dragonsByType = type.Value;

                var avgDamage = dragonsByType.Values.Average(a => a[0]);
                var avgHealth = dragonsByType.Values.Average(a => a[1]);
                var avgArmor = dragonsByType.Values.Average(a => a[2]);

                Console.WriteLine($"{typeName}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2}) ");
                foreach (var dragon in dragonsByType)
                {
                    var dragonName = dragon.Key;
                    var dragonStats = dragon.Value;
                    var damage = dragonStats[0];
                    var health = dragonStats[1];
                    var armor = dragonStats[2];

                    Console.WriteLine($"-{dragon.Key} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
