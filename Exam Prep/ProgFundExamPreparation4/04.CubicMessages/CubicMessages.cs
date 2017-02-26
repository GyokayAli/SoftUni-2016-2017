namespace _04.CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class CubicMessages
    {
        public static void Main()
        {
            var encryptedMessage = Console.ReadLine();

            while (!encryptedMessage.Equals("Over!"))
            {
                int count = int.Parse(Console.ReadLine());
                var pattern = new Regex(@"^([0-9]+)([a-zA-Z]{" + count + @"})([^a-zA-Z]*)$");

                var match = pattern.Match(encryptedMessage);

                if (match.Success)
                {
                    var message = match.Groups[2].ToString();
                    Console.Write(message + " == ");
                    List<int> indexes = GetIndexes(match);

                    foreach (var i in indexes)
                    {
                        if (0 <= i && i < message.Length)
                        {
                            Console.Write(message[i]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
                encryptedMessage = Console.ReadLine();
            }
        }

        private static List<int> GetIndexes(Match match)
        {
            var indexes = new List<int>();
            var left = match.Groups[1].ToString();
            for (int i = 0; i < left.Length; i++)
            {
                if (char.IsDigit(left[i]))
                {
                    indexes.Add(int.Parse(left[i].ToString()));
                }
            }

            var right = match.Groups[3].ToString();
            for (int i = 0; i < right.Length; i++)
            {
                if (char.IsDigit(right[i]))
                {
                    indexes.Add(int.Parse(right[i].ToString()));
                }
            }

            return indexes;
        }
    }
}
