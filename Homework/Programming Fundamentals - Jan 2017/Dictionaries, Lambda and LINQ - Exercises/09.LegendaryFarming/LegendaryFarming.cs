using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming
{
    static void Main()
    {
        var keyMaterials = new SortedDictionary<string, long>();
        keyMaterials["shards"] = 0;
        keyMaterials["motes"] = 0;
        keyMaterials["fragments"] = 0;

        var junkMaterials = new SortedDictionary<string, long>();
        bool isInput = true;

        while (isInput)
        {
            string[] materials = Console.ReadLine().ToLower().Split(' ').ToArray();

            for (int i = 0; i < materials.Length; i += 2)
            {
                long currQuantity = long.Parse(materials[i]);
                string currMaterial = materials[i + 1];
                if (currMaterial == "shards" || currMaterial == "motes" || currMaterial == "fragments")
                {
                    keyMaterials[currMaterial] += currQuantity;
                }
                else
                {
                    if (!junkMaterials.ContainsKey(currMaterial))
                    {
                        junkMaterials.Add(currMaterial, 0);
                    }
                    junkMaterials[currMaterial] += currQuantity;
                }

                if (keyMaterials["shards"] >= 250 || keyMaterials["motes"] >= 250 || keyMaterials["fragments"] >= 250)
                {
                    foreach (var item in keyMaterials.OrderByDescending(x => x.Value))
                    {
                        switch (item.Key)
                        {
                            case "motes":
                                Console.WriteLine("Dragonwrath obtained!");
                                keyMaterials[item.Key] -= 250;
                                break;
                            case "shards":
                                Console.WriteLine("Shadowmourne obtained!");
                                keyMaterials[item.Key] -= 250;
                                break;
                            case "fragments":
                                Console.WriteLine("Valanyr obtained!");
                                keyMaterials[item.Key] -= 250;
                                break;
                        }
                        break;
                    }

                    foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine("{0}: {1}", item.Key, item.Value);
                    }
                    foreach (var item in junkMaterials)
                    {
                        Console.WriteLine("{0}: {1}", item.Key, item.Value);
                    }
                    return;
                }
            }
        }
    }
}