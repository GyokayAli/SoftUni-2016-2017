using System;

namespace _02.TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double charge = 0;
            double initCharge = 0;

            if (km >= 100)
            {
                charge = 0.06;
            }
            else if (km >= 20)
            {
                charge = 0.09;
            }
            else
            {
                initCharge = 0.70;
                charge = dayOrNight.Equals("day") ? 0.79 : 0.90;
            }

            var total = initCharge + (km * charge);
            Console.WriteLine(total);
        }
    }
}
