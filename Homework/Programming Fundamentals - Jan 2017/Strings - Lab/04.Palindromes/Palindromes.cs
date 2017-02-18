namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var textList = Console.ReadLine()
                .Split(new[] { ',', '!', '.', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromeList = new List<string>();
            foreach (var word in textList)
            {
                //check if palindrome
                if (word.SequenceEqual(word.Reverse()))
                {
                    palindromeList.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromeList.Distinct().OrderBy(x =>x)));
        }
    }
}
