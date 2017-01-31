namespace _11.EqualSums
{
    using System;
    using System.Linq;

    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isEqual = false;

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = nums.Take(i).Sum();
                int rightSum = nums.Skip(i + 1).Sum();
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;
                }
            }

            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
