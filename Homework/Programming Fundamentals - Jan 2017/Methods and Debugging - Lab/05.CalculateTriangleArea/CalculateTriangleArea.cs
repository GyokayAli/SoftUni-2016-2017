﻿namespace _05.CalculateTriangleArea
{
    using System;

    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area =  GetTriangleArea(width, height);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
