namespace _02.AdvertisementMessage
{
    using System;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            var numberOfMessages = int.Parse(Console.ReadLine());

            var phrases = new[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            var events = new[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            var authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var random = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                var phraseIndex = random.Next(0, phrases.Length);
                var eventIndex = random.Next(0, events.Length);
                var authorIndex = random.Next(0, authors.Length);
                var cityIndex = random.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[cityIndex]}");
            }
        }
    }
}
