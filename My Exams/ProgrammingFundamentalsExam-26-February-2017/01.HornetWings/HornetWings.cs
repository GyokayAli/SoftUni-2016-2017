namespace _01.HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var totalDistance = (wingFlaps / 1000.0) * distance;
            var totalTime = (wingFlaps / 100) + (wingFlaps / endurance) * 5;

            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
