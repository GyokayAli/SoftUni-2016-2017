namespace _07.GreaterOfTwoValues
{
    using System;

    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            if (type == "int")
            {
                int max = GetMax(int.Parse(first), int.Parse(second));
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char max = GetMax(char.Parse(first), char.Parse(second));
                Console.WriteLine(max);
            }
            else
            {
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        static int GetMax(int first, int second)
        {
            int max = 0;

            if (first > second)
                max = first;
            else
                max = second;

            return max;
        }

        static char GetMax(char first, char second)
        {
            char max = new char();

            if (first.CompareTo(second) >= 0)
                max = first;
            else
                max = second;

            return max;
        }

        static string GetMax(string first, string second)
        {
            string max = string.Empty;

            if (first.CompareTo(second) >= 0)
                max = first;
            else
                max = second;

            return max;
        }
    }
}
