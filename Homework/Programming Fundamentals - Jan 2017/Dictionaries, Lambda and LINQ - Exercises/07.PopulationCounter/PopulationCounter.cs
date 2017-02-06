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

            var countryDataDict = new Dictionary<string, Dictionary<string, long>>();
            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = int.Parse(input[2]);

                if (!countryDataDict.ContainsKey(country))
                {
                    countryDataDict[country] = new Dictionary<string, long>();
                }

                countryDataDict[country][city] = population;

                input = Console.ReadLine()
                .Split('|')
                .ToArray();
            }

            //holds each country's total population and name
            var countryTotalPopDict = new Dictionary<string, long>();
            foreach (var city in countryDataDict)
            {
                long totalPopulation = 0;

                foreach (var pair in city.Value)
                {
                    totalPopulation += pair.Value;
                }
                countryTotalPopDict[city.Key] = totalPopulation;
            }

            //retrieve country -> country population, and sort by descending order (population)
            foreach (var country in countryTotalPopDict.OrderByDescending(x => x.Value))
            {
                var countryName = country.Key;
                var countryPopulation = country.Value;

                Console.WriteLine($"{countryName} (total population: {countryPopulation})");

                //retrieve country -> { city -> city population }
                foreach (var countryData in countryDataDict)
                {
                    //check if it points to the same country
                    if (country.Key == countryData.Key)
                    {
                        //retrieve city -> city population, and sort by descending order (population)
                        foreach (var data in countryData.Value.OrderByDescending(x => x.Value))
                        {
                            var cityName = data.Key;
                            var cityPopulation = data.Value;

                            Console.WriteLine($"=>{cityName}: {cityPopulation}");
                        }
                    }
                }
            }
        }
    }
}
