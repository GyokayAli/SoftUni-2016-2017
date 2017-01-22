﻿using System;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsDigit(symbol))
            {
                Console.WriteLine("digit");
            }
            else
            {
                bool isVowel = false;
                char[] vowels = { 'a', 'e', 'o', 'i', 'u' };

                for (int i = 0; i < vowels.Length; i++)
                {
                    isVowel = vowels[i].Equals(symbol);
                    if (isVowel) break;
                }

                Console.WriteLine(isVowel ? "vowel" : "other");
            }
        }
    }
}
