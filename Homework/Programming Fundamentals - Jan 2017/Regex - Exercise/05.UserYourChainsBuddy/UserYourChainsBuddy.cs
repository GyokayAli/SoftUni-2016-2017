namespace _05.UserYourChainsBuddy
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    public class UserYourChainsBuddy
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string html = Console.ReadLine();

            string pattern = @"<p>(.[^\/]+)<\/p>";
            string regex = @"[^a-z0-9]+";

            var words = new Regex(pattern);
            var matches = words.Matches(html);

            string encrypted = string.Empty;
            for (int i = 0; i < matches.Count; i++)
            {
                string temp = matches[i].Groups[1].Value;
                encrypted += Regex.Replace(temp, regex, word => " ");
            }

            // decrypting
            string manual = string.Empty;
            for (int i = 0; i < encrypted.Length; i++)
            {
                if (encrypted[i] >= 'a' && encrypted[i] <= 'm')
                {
                    manual += (char)(encrypted[i] + 13);
                }
                else if (encrypted[i] >= 'n' && encrypted[i] <= 'z')
                {
                    manual += (char)(encrypted[i] - 13);
                }
                else if (char.IsDigit(encrypted[i]) || char.IsWhiteSpace(encrypted[i]))
                {
                    manual += encrypted[i];
                }
            }
            Console.WriteLine(manual);
        }
    }
}
