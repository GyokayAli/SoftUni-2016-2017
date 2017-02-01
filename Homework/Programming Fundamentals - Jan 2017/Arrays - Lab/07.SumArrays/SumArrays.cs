namespace _07.SumArrays
{
    using System;
    using System.Linq;

    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] nums2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] duplicateArr = new int[Math.Max(nums1.Length, nums2.Length)];
            int sum = Math.Max(nums1.Length, nums2.Length);

            for (int i = 0; i <= duplicateArr.Length; i++)
            {
                sum = (nums1[i % nums1.Length] + nums2[i % nums2.Length]);
                if (i >= duplicateArr.Length)
                {
                    break;
                }
                Console.Write(sum + " ");
            }
        }
    }
}
