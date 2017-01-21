using System;

namespace _01.FishMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            decimal skumriaPerKg = decimal.Parse(Console.ReadLine());
            decimal cacaPerKg = decimal.Parse(Console.ReadLine());
            decimal palamudKg = decimal.Parse(Console.ReadLine());
            decimal safridKg = decimal.Parse(Console.ReadLine());
            decimal midaKg = decimal.Parse(Console.ReadLine());

            //Notes:
            //palamud 60% more expensive than skumria
            //safrid 80% more expensive than caca
            //mida 7.50 per kilo

            decimal palamudPerKg = skumriaPerKg + (skumriaPerKg * 0.60m);
            decimal totalPalamudCost = palamudPerKg * palamudKg;

            decimal safridPerKg = cacaPerKg + (cacaPerKg * 0.80m);
            decimal totalSafridCost = safridPerKg * safridKg;

            decimal totalMidaCost = midaKg * 7.50m;

            decimal totalCost = totalPalamudCost + totalSafridCost + totalMidaCost;

            Console.WriteLine(Math.Round(totalCost, 2));
        }
    }
}
