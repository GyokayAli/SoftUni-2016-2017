using System;

namespace _02.CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(circleRadius, 2);

            Console.WriteLine(string.Format("{0:F12}", circleArea));
        }
    }
}
