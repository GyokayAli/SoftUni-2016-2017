namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppendLists
    {
        static void Main(string[] args)
        {
            var fullList = Console.ReadLine()
                .Split('|')
                .ToList();

            fullList.Reverse();

            var resultList = new List<string>();

            foreach (var list in fullList)
            {
                var numsList = list.Split(' ').ToList();
                foreach (var num in numsList)
                {
                    if(!string.IsNullOrEmpty(num))
                    {
                        resultList.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
