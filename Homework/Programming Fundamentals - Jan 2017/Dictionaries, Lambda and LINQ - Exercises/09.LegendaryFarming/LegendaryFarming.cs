namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LegendaryFarming
    {
        static void Main()
        {
            var materialQuantDic = new Dictionary<string, long>();
            var junkSortDict = new SortedDictionary<string, long>();

            materialQuantDic["shard"] = 0;
            materialQuantDic["fragments"] = 0;
            materialQuantDic["motes"] = 0;

            bool isNotEnough = true;
            while (isNotEnough)
            {
                var resourceLine = Console.ReadLine()
                    .ToLower()
                    .Split(' ')
                    .ToArray();

                for (int i = 0; i < resourceLine.Length; i += 2)
                {
                    var quantity = long.Parse(resourceLine[i]);
                    string material = resourceLine[i + 1];

                    if (materialQuantDic.ContainsKey(material))
                    {
                        materialQuantDic[material] += quantity;
                        if (materialQuantDic[material] >= 250)
                        {
                            materialQuantDic[material] -= 250;
                            string result = string.Empty;
                            switch (material)
                            {
                                case "shards": result = "Shadowmourne"; break;
                                case "fragments": result = "Valanyr"; break;
                                case "motes": result = "Dragonwrath"; break;
                            }
                            Console.WriteLine("{0} obtained!", result);
                            isNotEnough = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkSortDict.ContainsKey(material))
                        {
                            junkSortDict.Add(material, 0);
                        }
                        junkSortDict[material] += quantity;
                    }
                }
            }

            //print the remaining key materials in descending order by quantity then by alphabetical order
            var extraResources = materialQuantDic.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var usefulMaterial in extraResources)
            {
                var materialName = usefulMaterial.Key;
                var materialQuant = usefulMaterial.Value;
                Console.WriteLine($"{materialName}: {materialQuant}");
            }
            //print the junk items in alphabetical order
            foreach (var junkMaterial in junkSortDict)
            {
                var materialName = junkMaterial.Key;
                var materialQuant = junkMaterial.Value;
                Console.WriteLine($"{materialName}: {materialQuant}");
            }
        }
    }
}
