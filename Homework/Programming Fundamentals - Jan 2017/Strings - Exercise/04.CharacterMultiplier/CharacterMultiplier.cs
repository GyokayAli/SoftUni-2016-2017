namespace _04.CharacterMultiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var result = MultiplyCharacters(input[0], input[1]);

            Console.WriteLine(result);
        }

        static int MultiplyCharacters(string str1, string str2)
        {
            var minLength = Math.Min(str1.Length, str2.Length);
            var maxLength = Math.Max(str1.Length, str2.Length);

            var result = 0;
            for (int i = 0; i < minLength; i++)
            {
                result += str1[i] * str2[i];
            }

            if (str1.Length != str2.Length)
            {
                string longerString = str1.Length > str2.Length ? str1 : str2;
                for (int i = minLength; i < maxLength; i++)
                {
                    result += longerString[i];
                }
            }

            return result;
        }
    }
}
