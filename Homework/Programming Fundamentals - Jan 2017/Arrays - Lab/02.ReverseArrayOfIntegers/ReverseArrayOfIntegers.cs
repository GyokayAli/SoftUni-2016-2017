namespace _02.ReverseArrayOfIntegers
{
    using System;

    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numsArray = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                numsArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", numsArray));
        }
    }
}
