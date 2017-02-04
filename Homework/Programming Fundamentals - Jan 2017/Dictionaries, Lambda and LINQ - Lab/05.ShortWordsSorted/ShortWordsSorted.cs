namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var wordsList = Console.ReadLine()
                .ToLower()
                .Split(new[] { '.', ',', '\'', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", wordsList));
        }
    }
}
