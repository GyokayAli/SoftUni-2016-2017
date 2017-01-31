namespace _02.RotateAndSum
{
    using System;
    using System.Linq;

    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rotate = int.Parse(Console.ReadLine());
            int len = nums.Length;
            int[] sum = new int[len];

            for (int i = 0; i < rotate; i++)
            {
                int last = nums[len - 1];

                for (int j = len - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = last;

                for (int k = 0; k < len; k++)
                {
                    sum[k] += nums[k];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}