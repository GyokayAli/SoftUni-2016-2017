using System;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFirst = int.Parse(Console.ReadLine());
            int nSecond = int.Parse(Console.ReadLine());
            int maxBattle = int.Parse(Console.ReadLine());

            int k = 0;
            for (int i = 1; i <= nFirst; i++)
            {
                for (int j = 1; j <= nSecond; j++)
                {
                    Console.Write("({0} <-> {1}) ", i, j);
                    k++;

                    if (k == maxBattle)
                    {
                        break;
                    }
                }

                if (k == maxBattle)
                {
                    break;
                }
            }
        }
    }
}
