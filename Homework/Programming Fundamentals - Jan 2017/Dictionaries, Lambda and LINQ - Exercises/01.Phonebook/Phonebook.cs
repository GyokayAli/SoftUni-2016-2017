namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Phonebook
    {
        static void Main(string[] args)
        {
            var entries = Console.ReadLine()
                .Split()
                .ToList();

            var phonebook = new Dictionary<string, string>();

            while (entries[0] != "END")
            {
                if (entries[0] == "A")
                {
                    phonebook[entries[1]] = entries[2];
                }
                else if (entries[0] == "S")
                {
                    if (phonebook.ContainsKey(entries[1]))
                    {
                        Console.WriteLine($"{entries[1]} -> {phonebook[entries[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {entries[1]} does not exist.");
                    }
                }
                entries = Console.ReadLine().Split().ToList();
            }
        }
    }
}
