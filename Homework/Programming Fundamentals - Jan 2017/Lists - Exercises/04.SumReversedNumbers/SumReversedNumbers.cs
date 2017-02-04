namespace _04.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var reversedList = new List<int>();

            foreach (var num in numsList)
            {
                reversedList.Add(ReverseNumber(num));
            }

            Console.WriteLine(reversedList.Sum());
        }

        static int ReverseNumber(int n)
        {
            int left = n;
            int rev = 0;
            while (left > 0)
            {
                n = left % 10;
                rev = rev * 10 + n;
                left = left / 10; 
            }
            return rev;
        }
    }
}
