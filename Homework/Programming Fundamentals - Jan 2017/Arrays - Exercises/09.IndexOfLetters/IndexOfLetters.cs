namespace _09.IndexOfLetters
{
    using System;
    using System.Linq;

    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabet = Enumerable.Range('a', 'z' - 'a' + 1)
                .Select(i => (char)i)
                .ToArray();

            string letters = Console.ReadLine();

            for (int j = 0; j < letters.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letters[j].ToString().Contains(alphabet[i]))
                    {
                        Console.WriteLine("{0} -> {1}", letters[j], i);
                    }
                }
            }
        }
    }
}
