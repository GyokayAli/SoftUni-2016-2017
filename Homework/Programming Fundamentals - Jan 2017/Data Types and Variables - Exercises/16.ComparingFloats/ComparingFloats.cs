using System;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double diff = Math.Abs(a - b);
            float epsilon = 0.000001f;

            bool isEqual = false;

            isEqual = diff <= epsilon ? true : false;

            Console.WriteLine(isEqual);
        }
    }
}
