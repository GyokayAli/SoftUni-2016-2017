using System;

namespace _09.ReversedChars
{
    class ReversedChars
    {
        static void Main(string[] args)
        {
            char[] nums = new char[3];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = char.Parse(Console.ReadLine());
            }

            Array.Reverse(nums);
            Console.WriteLine(nums);
        }
    }
}
