namespace _05.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();
            var firstWord = words[0].ToCharArray();
            var secondWord = words[1].ToCharArray();

            var charList1 = new List<char>();
            var charList2 = new List<char>();

            for (int i = 0; i < firstWord.Length; i++)
            {
                if (!charList1.Any(x => x == firstWord[i]))
                {
                    charList1.Add(firstWord[i]);
                }
            }
            for (int i = 0; i < secondWord.Length; i++)
            {
                if (!charList2.Any(x => x == secondWord[i]))
                {
                    charList2.Add(secondWord[i]);
                }
            }

            Console.WriteLine(charList1.Count == charList2.Count ? "true" : "false");
        }
    }
}
