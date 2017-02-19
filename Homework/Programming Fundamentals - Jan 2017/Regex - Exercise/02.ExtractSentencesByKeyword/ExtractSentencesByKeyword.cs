namespace _02.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();

            var sentences = Console.ReadLine()
                .Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = "\\b" + keyword + "\\b"; //word boundary
            var regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
