namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var squareNumsList = new List<int>();

            foreach (var num in numsList)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNumsList.Add(num);        
                }
            }

            //sort in descending order
            squareNumsList.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumsList));
        }
    }
}
