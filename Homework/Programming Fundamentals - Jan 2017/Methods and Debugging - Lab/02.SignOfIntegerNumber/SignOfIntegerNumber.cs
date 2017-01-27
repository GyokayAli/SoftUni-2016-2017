namespace _02.SignOfIntegerNumber
{
    using System;

    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        static void PrintSign(int number)
        {
            string sign = string.Empty;

            if(number == 0)
            {
                sign = "zero";
            }
            else if (number > 0)
            {
                sign = "positive";
            }
            else
            {
                sign = "negative";
            }

            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
