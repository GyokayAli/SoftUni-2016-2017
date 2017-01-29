namespace _11.GeometryCalculator
{
    using System;

    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape.Equals("triangle"))
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfTriangle(side, height).ToString("F"));
            }
            if (shape.Equals("rectangle"))
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfRectangle(width, height).ToString("F"));
            }
            if (shape.Equals("circle"))
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfCircle(radius).ToString("F"));
            }
            if (shape.Equals("square"))
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfSquare(side).ToString("F"));
            }
        }

        static double AreaOfTriangle(double side, double height)
        {
            return (side * height) / 2;
        }

        static double AreaOfSquare(double side)
        {
            return Math.Pow(side, 2);
        }

        static double AreaOfRectangle(double width, double height)
        {
            return width * height;
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
