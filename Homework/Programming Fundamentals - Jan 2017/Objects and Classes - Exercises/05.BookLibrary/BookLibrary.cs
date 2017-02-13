namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var library = new Library();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var title = input[0];
                var author = input[1];
                var published = input[2];
                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = input[4];
                var price = decimal.Parse(input[5]);

                Book book = null;
                if (!library.Books.Any(x => x.Author == author))
                {
                    book = new Book(title, author, published, releaseDate, isbn, price);
                    library.Books.Add(book);
                }
                else
                {
                    book = library.Books.First(x => x.Author == author);
                    book.Price += price;
                }
            }

            foreach (var item in library.Books.OrderByDescending(x => x.Price).ThenBy(x => x.Author))
            {
                Console.WriteLine($"{item.Author} -> {item.Price:F2}");
            }
        }
    }
}
