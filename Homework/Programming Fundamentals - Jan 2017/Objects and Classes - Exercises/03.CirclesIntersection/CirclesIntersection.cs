namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;

    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstCircleArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var secondCircleArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Point firstCenter = new Point(firstCircleArr[0], firstCircleArr[1]);
            Point secondCenter = new Point(secondCircleArr[0], secondCircleArr[1]);

            Circle firstCircle = new Circle(firstCenter, firstCircleArr[2]);
            Circle secondCircle = new Circle(secondCenter, secondCircleArr[2]);

            Console.WriteLine(Circle.Intersect(firstCircle, secondCircle) ? "Yes" : "No");
        }
    }
}
