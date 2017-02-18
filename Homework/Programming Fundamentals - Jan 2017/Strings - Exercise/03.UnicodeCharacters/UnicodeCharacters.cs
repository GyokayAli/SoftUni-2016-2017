namespace _03.UnicodeCharacters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var characters = Console.ReadLine().ToCharArray();

            foreach (var letter in characters)
            {
                Console.Write($"\\u{(int)letter:x4}");
            }
        }
    }
}
