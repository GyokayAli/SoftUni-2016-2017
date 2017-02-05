namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(':')
                .ToArray();

            var playersCards = new Dictionary<string, string>();

            while (!input[0].Equals("JOKER"))
            {
                if (!playersCards.ContainsKey(input[0]))
                {
                    playersCards[input[0]] = input[1];
                }
                else
                {
                    playersCards[input[0]] += input[1];
                }

                input = Console.ReadLine()
                    .Split(':')
                    .ToArray();
            }

            var playersResults = new Dictionary<string, int>();

            foreach (var hand in playersCards)
            {
                var cards = hand.Value
                    .Split(new char[] { ':', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

                var finalResult = 0;

                for (int i = 0; i < cards.Count; i++)
                {
                    var result = 1;

                    foreach (var ch in cards[i])
                    {
                        switch (ch)
                        {
                            case '0': result *= 10; break;
                            case '1': result *= 1; break;
                            case '2': result *= 2; break;
                            case '3': result *= 3; break;
                            case '4': result *= 4; break;
                            case '5': result *= 5; break;
                            case '6': result *= 6; break;
                            case '7': result *= 7; break;
                            case '8': result *= 8; break;
                            case '9': result *= 9; break;
                            case 'J': result *= 11; break;
                            case 'Q': result *= 12; break;
                            case 'K': result *= 13; break;
                            case 'A': result *= 14; break;
                            case 'S': result *= 4; break;
                            case 'H': result *= 3; break;
                            case 'D': result *= 2; break;
                            case 'C': result *= 1; break;
                            default:
                                break;
                        }
                    }

                    finalResult += result;
                }
                playersResults[hand.Key] = finalResult;
            }

            foreach (var kvp in playersResults)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}