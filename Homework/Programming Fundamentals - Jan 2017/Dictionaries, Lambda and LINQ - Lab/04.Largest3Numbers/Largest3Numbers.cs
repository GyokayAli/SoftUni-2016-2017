namespace _04.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", numsList));    
        }
    }
}
