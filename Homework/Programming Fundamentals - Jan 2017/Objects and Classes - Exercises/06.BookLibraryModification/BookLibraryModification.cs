namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var bookDictionary = new Dictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var title = input[0];
                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (!bookDictionary.ContainsKey(title))
                {
                    bookDictionary[title] = new DateTime();
                }
                bookDictionary[title] = releaseDate;
            }

            var givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in bookDictionary.Where(x => x.Value > givenDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
