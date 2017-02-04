namespace _06.FoldAndSum
{
    using System;
    using System.Linq;

    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = nums.Length / 4;

            var firstPart = nums.Take(k).Reverse().ToArray();
            var midPart = nums.Skip(k).Take(2 * k).ToArray();
            var lastPart = nums.Reverse().Take(k);

            var mergedFirstAndLast = firstPart.Concat(lastPart);

            var sumOfArrays = mergedFirstAndLast.Zip(midPart, (x, y) => x + y);

            Console.WriteLine(string.Join(" ", sumOfArrays));
        }
    }
}
