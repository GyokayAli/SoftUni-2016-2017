using System;

namespace _04.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curr = 0;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            for (int i = 0; i < n; i++)
            {
                curr = int.Parse(Console.ReadLine());

                if (curr < 200)
                {
                    c1++;
                }
                else if (curr > 199 && curr < 400)
                {
                    c2++;
                }
                else if (curr > 399 && curr < 600)
                {
                    c3++;
                }
                else if (curr > 599 && curr < 800)
                {
                    c4++;
                }
                else
                {
                    c5++;
                }
            }

            var p1 = c1 / (decimal)n * 100;
            var p2 = c2 / (decimal)n * 100;
            var p3 = c3 / (decimal)n * 100;
            var p4 = c4 / (decimal)n * 100;
            var p5 = c5 / (decimal)n * 100;

            Console.WriteLine(@"{0:0.00}%
{1:0.00}%
{2:0.00}%
{3:0.00}%
{4:0.00}%", p1, p2, p3, p4, p5);
        }
    }
}
