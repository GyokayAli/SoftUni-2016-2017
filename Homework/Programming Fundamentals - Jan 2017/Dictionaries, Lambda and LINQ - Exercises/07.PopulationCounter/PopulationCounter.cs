namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToArray();

            var populationDic = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = int.Parse(input[2]);

                if (!populationDic.ContainsKey(country))
                {
                    populationDic[country] = new Dictionary<string, int>();
                }

                populationDic[country][city] = population;

                input = Console.ReadLine()
                .Split('|')
                .ToArray();
            }

            foreach (var kvp in populationDic.OrderByDescending(x => x.Key))
            {
                var country = kvp.Key;
                var citiesByPopulation = kvp.Value;
                var totalCountryPopulation = citiesByPopulation.Values.Sum();

                Console.WriteLine($"{country} (total population: {totalCountryPopulation})");

                foreach (var city in citiesByPopulation.OrderByDescending(x => x.Value))
                {
                    var cityName = city.Key;
                    var cityPopulation = city.Value;

                    Console.WriteLine($"=>{cityName}: {cityPopulation}");
                }
            }
        }
    }
}
