using System;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            decimal dogKg = decimal.Parse(Console.ReadLine());
            decimal catKg = decimal.Parse(Console.ReadLine());
            decimal tortGram = decimal.Parse(Console.ReadLine());

            var dogNeeds = days * dogKg;
            var catNeeds = days * catKg;
            var tortNeeds = days * (tortGram / 1000);

            var totalNeeded = dogNeeds + catNeeds + tortNeeds;

            if(totalNeeded <= foodKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodKg - totalNeeded));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalNeeded - foodKg));
            }
        }
    }
}
