using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAdults = int.Parse(Console.ReadLine());
            int numStuds = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transportType = Console.ReadLine();

            int totalPeople = numAdults + numStuds;
            double perNight = 82.99;
            double comm = 0.1;

            double studTransCost = 0;
            double adultTransCost = 0;

            switch (transportType)
            {
                case "train":

                    if (totalPeople >= 50)
                    {
                        adultTransCost = 24.99 * 0.5;
                        studTransCost = 14.99 * 0.5;
                    }
                    else
                    {
                        adultTransCost = 24.99;
                        studTransCost = 14.99;
                    }
                    break;
                case "bus":
                    adultTransCost = 32.50;
                    studTransCost = 28.50;
                    break;
                case "boat":
                    adultTransCost = 42.99;
                    studTransCost = 39.99;
                    break;
                case "airplane":
                    adultTransCost = 70;
                    studTransCost = 50;
                    break;
            }

            double transCost = ((numAdults * adultTransCost) + (numStuds * studTransCost)) * 2;
            double hotelCost = nights * perNight;
            double totalComm = (transCost + hotelCost) * comm;

            double finalCost = transCost + hotelCost + totalComm;

            Console.WriteLine(finalCost.ToString("#.##"));
        }
    }
}
