using System;

namespace _01.TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()) * 100;
            double h = (double.Parse(Console.ReadLine()) * 100) - 100;

            double numDesk = Math.Truncate(h / 70);
            double numRow = Math.Truncate(w / 120);

            double numSeatsTotal = (numDesk * numRow) - 3;

            Console.WriteLine(numSeatsTotal);
        }
    }
}
