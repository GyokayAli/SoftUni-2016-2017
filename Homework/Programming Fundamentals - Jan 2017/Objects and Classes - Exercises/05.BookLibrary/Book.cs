namespace _05.BookLibrary
{
    using System;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, string published, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = published;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }
    }
}
