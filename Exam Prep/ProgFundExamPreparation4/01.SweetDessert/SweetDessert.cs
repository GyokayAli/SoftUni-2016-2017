namespace _01.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            var moneyInCash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPricePerUnit = decimal.Parse(Console.ReadLine());
            var eggPricePerUnit = decimal.Parse(Console.ReadLine());
            var berryPricePerKg = decimal.Parse(Console.ReadLine());

            var sets = Math.Ceiling(guests / 6.00m);
            var totalCost = sets * (2 * bananaPricePerUnit) + sets * (4 * eggPricePerUnit) + sets * (0.2m * berryPricePerKg);

            if (totalCost <= moneyInCash)
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            else
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalCost - moneyInCash:F2}lv more.");
        }
    }
}
