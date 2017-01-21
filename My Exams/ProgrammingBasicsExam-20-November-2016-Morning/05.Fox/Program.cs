using System;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            int width = (2 * n) + 3;
            int sides = 4;
            int mid = width - sides;
            int midBelow = width - sides;
            int leftStars = 2;
            int leftDots = 2;

            //top
            Console.WriteLine("*\\{0}/*", new string('-', mid));
            //below top
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', leftStars++), new string('-', mid -= 2));
            }
            //mid
            int midEyeStar = n;
            int sideEyeStar = n / 2;

            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', sideEyeStar++), new string('*', midEyeStar));
                midEyeStar -= 2;
            }

            //below mid
            Console.WriteLine("-\\{0}/-", new string('*', midBelow));
            //bot
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', leftDots++), new string('*', midBelow -= 2));
            }
        }
    }
}
