namespace _08.MultiplyEvensByOdds
{
    using System;

    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sumEvens = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEvens += lastDigit;
                }

                n /= 10;
            }

            return sumEvens;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sumOdds = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdds += lastDigit;
                }

                n /= 10;
            }

            return sumOdds;
        }
    }
}