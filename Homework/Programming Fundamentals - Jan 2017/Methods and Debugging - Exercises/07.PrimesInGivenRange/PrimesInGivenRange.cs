namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primesList = FindPrimesInRange(start, end);
            PrintList(primesList);
        }

        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> listPrimes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    listPrimes.Add(i);
                }
            }
            return listPrimes;
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintList(List<int> primesList)
        {
            string joined = string.Join(", ", primesList);
            Console.WriteLine(joined);
        }
    }
}
