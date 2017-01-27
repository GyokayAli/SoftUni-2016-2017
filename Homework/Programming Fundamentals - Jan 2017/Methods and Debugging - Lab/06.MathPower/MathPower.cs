namespace _06.MathPower
{
    using System;

    class MathPower
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            double result = RaiseToPow(num, pow);

            Console.WriteLine(result);
        }

        static double RaiseToPow(double num, int pow)
        {
            double result = 0d;
            result = Math.Pow(num, pow);

            return result;
        }
    }
}
