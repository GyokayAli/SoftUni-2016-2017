using System;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int firstDigit = i / 10;
                int lastDigit = i % 10;
                int sum = firstDigit + lastDigit;

                bool isTrue = (sum == 5 || sum == 7 || sum == 11);

                Console.WriteLine(i + " -> " + isTrue);
            }
        }
    }
}
