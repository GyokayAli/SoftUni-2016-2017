using System;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long totalPics = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long filteredPics = (long)Math.Ceiling(totalPics * ((double)filterFactor / 100));
            long totalTime = (totalPics * filterTime) + (filteredPics * uploadTime);

            TimeSpan ts = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine(ts.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
