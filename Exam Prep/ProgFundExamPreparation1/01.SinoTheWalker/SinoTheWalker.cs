namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var startTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            var totalSteps = ulong.Parse(Console.ReadLine());
            var timePerStep = ulong.Parse(Console.ReadLine());

            ulong totalSeconds = totalSteps * timePerStep;
            var totalSecondsPerDay = totalSeconds % (24 * 60 * 60);

            var finalDate = startTime.AddSeconds(totalSecondsPerDay);

            Console.WriteLine($"Time Arrival: {finalDate.ToString("HH:mm:ss")}");
        }
    }
}
