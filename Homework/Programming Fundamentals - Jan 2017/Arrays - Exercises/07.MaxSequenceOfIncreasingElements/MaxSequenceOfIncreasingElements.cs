namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = nums.Length;

            int curr = 0;
            int startSeq = 0;
            int max = 0;
            int startMaxSeq = 0;

            for (int i = 1; i < len; i++)
            {
                if (nums[i] - nums[i - 1] >= 1)
                {
                    curr++;
                    startSeq = i - curr;

                    if (curr > max)
                    {
                        max = curr;
                        startMaxSeq = startSeq;
                    }
                }
                else
                {
                    curr = 0;
                }
            }

            for (int i = startMaxSeq; i <= (startMaxSeq + max); i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}