using System;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            //distance in meters
            int distance = int.Parse(Console.ReadLine());

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            //meters to miles convertion
            float miles = distance / 1609f;
            //calc total seconds
            int totalSeconds = seconds + (60 * minutes) + (3600 * hours);

            float metersPerSecond = distance / (float)totalSeconds;
            float kmPerHour = (distance / 1000f) / (totalSeconds / 3600f);
            float milesPerHour = miles / (totalSeconds / 3600f);

            Console.WriteLine($"{metersPerSecond}\n{kmPerHour}\n{milesPerHour}");
        }
    }
}
