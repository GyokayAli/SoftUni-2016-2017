using System;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGroup = int.Parse(Console.ReadLine());
            int[] arrGroup = new int[numGroup];

            int totalPeople = 0;
            int car = 0;
            int microbus = 0;
            int smallBus = 0;
            int bigBus = 0;
            int train = 0;

            for (int i = 0; i < numGroup; i++)
            {
                arrGroup[i] = int.Parse(Console.ReadLine());
                totalPeople += arrGroup[i];

                if (arrGroup[i] <= 5)
                {
                    car += arrGroup[i];
                }
                else if (arrGroup[i] > 5 && arrGroup[i] <= 12)
                {
                    microbus += arrGroup[i];
                }
                else if (arrGroup[i] > 12 && arrGroup[i] <= 25)
                {
                    smallBus += arrGroup[i];
                }
                else if (arrGroup[i] > 25 && arrGroup[i] <= 40)
                {
                    bigBus += arrGroup[i];
                }
                else
                {
                    train += arrGroup[i];
                }
            }

            var carPercent = (car / (decimal)totalPeople) * 100;
            var microbusPercent = (microbus / (decimal)totalPeople) * 100;
            var smallBusPercent = (smallBus / (decimal)totalPeople) * 100;
            var bigBusPercent = (bigBus / (decimal)totalPeople) * 100;
            var trainPercent = (train / (decimal)totalPeople) * 100;

            Console.WriteLine(@"{0}%
{1}%
{2}%
{3}%
{4}%", carPercent.ToString("n2"), microbusPercent.ToString("n2"), smallBusPercent.ToString("n2"), bigBusPercent.ToString("n2"), trainPercent.ToString("n2"));
        }
    }
}
