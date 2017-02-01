namespace _05.SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortNumbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            numsList.Sort();

            Console.WriteLine(string.Join(" <= ", numsList));
        }
    }
}
