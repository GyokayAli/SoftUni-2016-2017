namespace _03.ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;
    public class ValidUsernames
    {
        public static void Main()
        {
            var usernames = Console.ReadLine()
                .Split(new[] { '/', '\\', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = @"^(?=.{3,25}$)[a-zA-Z0-9._]+$";
            var regex = new Regex(pattern);
            foreach (var username in usernames)
            {
                if (regex.IsMatch(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
