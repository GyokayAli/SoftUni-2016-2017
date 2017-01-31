namespace _01.LargestCommonEnd
{
    using System;
    using System.Linq;

    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine()
                .Split(' ');
            string[] words2 = Console.ReadLine()
                .Split(' ');

            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < words1.Length && i < words2.Length; i++)
            {
                if (words1[i] == words2[i])
                {
                    countLeft++;
                }
            }
            for (int j = 0; j < words1.Length && j < words2.Length; j++)
            {
                if (words1[words1.Length - 1 - j] == words2[words2.Length - 1 - j])
                {
                    countRight++;
                }
            }
            Console.WriteLine(countRight > countLeft ? countRight : countLeft);
        }
    }
}
