namespace _01.ReplaceTag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            string html = Console.ReadLine();

            while (html != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(html, pattern, replace);

                Console.WriteLine(replaced);
                html = Console.ReadLine();
            }
        }
    }
}
