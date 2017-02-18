namespace _03.TextFilter
{
    using System;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            var bannerdWords = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();

            foreach (var word in bannerdWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
