namespace _03.EnglishNameOfLastDigit
{
    using System;
    using System.Numerics;

    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long num = Math.Abs(long.Parse(Console.ReadLine()));

            string digitAsWord = GetDigitAsWord(num);

            Console.WriteLine(digitAsWord);
        }

        static string GetDigitAsWord(long num)
        {
            long lastDigit = num % 10;

            string[] digitsAsLetters = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string digitAsWord = digitsAsLetters[lastDigit];

            return digitAsWord;
        }
    }
}
