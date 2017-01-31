namespace _03.FoldAndSum
{
    using System;
    using System.Linq;

    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int len = nums.Length;

            var first = nums.Take(len / 4).Reverse();
            var last = nums.Reverse().Take(len / 4);

            int[] topMerged = first.Concat(last).ToArray();
            int[] bottom = nums.Skip(len / 4).Take(len / 2).ToArray();

            //sum of topMerged and bottom arrays
            int[] sum = topMerged.Select((x, index) => x + bottom[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
