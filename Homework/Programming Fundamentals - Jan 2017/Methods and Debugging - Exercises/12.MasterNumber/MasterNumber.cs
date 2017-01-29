namespace _12.MasterNumber
{
    using System;
    using System.Linq;

    class MasterNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (IsSumDivisibleBy7(i) && IsPalindrome(i) && HasOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            string numStr = num.ToString();
            return numStr.SequenceEqual(numStr.Reverse());
        }

        static bool IsSumDivisibleBy7(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HasOneEvenDigit(int num)
        {
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }
            return false;
        }
    }
}
