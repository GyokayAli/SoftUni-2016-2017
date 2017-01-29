namespace _02.MaxMethod
{
    using System;

    class MaxMethod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxAorB = GetMax(a, b);
            //biggest of three
            int max = GetMax(maxAorB, c);

            Console.WriteLine(max);
        }

        static int GetMax(int a, int b)
        {
            int result = Math.Max(a, b);
            return result;
        }
    }
}
