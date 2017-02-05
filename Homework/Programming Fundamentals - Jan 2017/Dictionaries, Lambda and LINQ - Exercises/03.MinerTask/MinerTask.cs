namespace _03.MinerTask
{
    using System;
    using System.Collections.Generic;

    class MinerTask
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            var resourceDict = new Dictionary<string, int>();

            while (!resource.Equals("stop"))
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourceDict.ContainsKey(resource))
                {
                    resourceDict[resource] = 0;
                }

                resourceDict[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var res in resourceDict)
            {
                Console.WriteLine("{0} -> {1}", res.Key, res.Value);
            }
        }
    }
}
