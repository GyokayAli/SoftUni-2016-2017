namespace _04.TrippleSum
{
    using System;
    using System.Linq;

    class TrippleSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int len = nums.Length;
            bool hasTrippleSum = false;

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (nums[i] + nums[j] == nums[k])
                        {
                            Console.WriteLine($"{nums[i]} + {nums[j]} == {nums[k]}");
                            hasTrippleSum = true;
                            break;
                        }
                    }
                }
            }
            if (!hasTrippleSum) Console.WriteLine("No");
        }
    }
}