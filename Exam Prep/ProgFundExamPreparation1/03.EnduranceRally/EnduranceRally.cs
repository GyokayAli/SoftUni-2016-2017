namespace _03.EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split(' ').ToList();
            var track = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpointIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                var fuel = (double)driver.First();
                var reachedIndex = 0;
                for (int i = 0; i < track.Length; i++)
                {
                    fuel = checkpointIndexes.Contains(i) ? fuel += track[i] : fuel -= track[i];

                    if (fuel < 1)
                    {
                        Console.WriteLine($"{driver} - reached {reachedIndex}");
                        break;
                    }

                    reachedIndex++;
                }

                if (fuel > 0)
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
            }
        }
    }
}
