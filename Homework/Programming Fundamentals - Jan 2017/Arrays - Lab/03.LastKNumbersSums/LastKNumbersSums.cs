namespace _03.LastKNumbersSums
{
    using System;
    using System.Linq;

    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] seq = new long[n];

            seq[0] = 1;

            for (long i = 1; i < n; i++)
            {
                long sum = 0, 
                     last = i - 1, 
                     toSteps = 1;

                while (last >= 0 && toSteps <= k)
                {
                    sum += seq[last--];
                    toSteps++;
                }

                seq[i] = sum;
            }

            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
