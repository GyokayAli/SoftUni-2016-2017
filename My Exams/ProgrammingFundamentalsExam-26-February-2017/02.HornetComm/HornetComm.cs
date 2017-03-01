namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class HornetComm
    {
        public static void Main()
        {
            //input format: {firstQuery} <-> {secondQuery}
            var input = Console.ReadLine();

            var privateList = new List<string>();
            var broadcastList = new List<string>();

            //(\d+) only for digits
            var messagePattern = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$";
            //(\D+) everything but digits 
            var broadcastPattern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";

            var privateRegex = new Regex(messagePattern);
            var broadcastRegex = new Regex(broadcastPattern);

            while (input != "Hornet is Green")
            {
                if (privateRegex.IsMatch(input))
                {
                    Match match = privateRegex.Match(input);

                    string recipientCode = string.Join("", match.Groups[1].Value.Reverse());
                    string message = match.Groups[2].Value;

                    privateList.Add(recipientCode + " -> " + message);
                }

                if (broadcastRegex.IsMatch(input))
                {
                    Match match = broadcastRegex.Match(input);
                    string message = match.Groups[1].Value;
                    string frequency = string.Empty;

                    foreach (char currentChar in match.Groups[2].Value)
                    {
                        if (currentChar >= 65 && currentChar <= 90)
                        {
                            frequency += (char)(currentChar + 32);
                        }
                        else if (currentChar >= 97 && currentChar <= 122)
                        {
                            frequency += (char)(currentChar - 32);
                        }
                        else
                        {
                            frequency += currentChar;
                        }
                    }
                    broadcastList.Add(frequency + " -> " + message);
                }

                input = Console.ReadLine();
            }

            //BROADCASTS
            Console.WriteLine("Broadcasts:");
            foreach (var msg in broadcastList)
            {
                Console.WriteLine($"{msg}");
            }

            if (!broadcastList.Any())
            {
                Console.WriteLine("None");
            }

            //MESSAGES
            Console.WriteLine("Messages:");
            foreach (var msg in privateList)
            {
                Console.WriteLine($"{msg}");
            }

            if (!privateList.Any())
            {
                Console.WriteLine("None");
            }
        }
    }
}
