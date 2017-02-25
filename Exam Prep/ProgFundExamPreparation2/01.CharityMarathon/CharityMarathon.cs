namespace _01.CharityMarathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var lapLength = double.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            var maxRunners = Math.Min(numberOfRunners, (days * trackCapacity));

            var totalMeters = maxRunners * averageLaps * lapLength;
            var totalKilometers = totalMeters / 1000;
            var moneyRaise = totalKilometers * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaise:F2}");
        }
    }
}
