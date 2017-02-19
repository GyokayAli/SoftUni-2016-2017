namespace _01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"\b(?<![\.\-_])([a-zA-Z][\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+\b";

            var regex = new Regex(pattern);
            var matchCollection = regex.Matches(text);

            foreach (var match in matchCollection)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
