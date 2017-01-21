using System;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;
                int sum = 0;

                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                bool isTrue = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{currentNum} -> {isTrue}");

                sum = 0;
                i = currentNum;
            }
        }
    }
}
