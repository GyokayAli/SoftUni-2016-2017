namespace _03.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (commands[0].Equals("add"))
                {
                    int index = int.Parse(commands[1]);
                    int item = int.Parse(commands[2]);
                    nums.Insert(index, item);
                }
                else if (commands[0].Equals("addMany"))
                {
                    int index = int.Parse(commands[1]);
                    var elements = commands
                        .Skip(2)
                        .Take(commands.Length - 2)
                        .Select(int.Parse)
                        .ToList();
                    nums.InsertRange(index, elements);
                }
                else if (commands[0].Equals("contains"))
                {
                    int element = int.Parse(commands[1]);
                    bool hasElement = nums.Contains(element);

                    if (hasElement)
                    {
                        Console.WriteLine(nums.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (commands[0].Equals("remove"))
                {
                    int index = int.Parse(commands[1]);
                    nums.RemoveAt(index);
                }
                else if (commands[0].Equals("shift"))
                {
                    int count = int.Parse(commands[1]);
                    for (int i = 0; i < count; i++)
                    {
                        int firstNum = nums[0];
                        nums.RemoveAt(0);
                        nums.Add(firstNum);
                    }
                }
                else if (commands[0].Equals("sumPairs"))
                {
                    for (int i = 0; i < nums.Count - 1; i++)
                    {
                        int sum = nums[i] + nums[i + 1];
                        nums.RemoveAt(i);
                        nums[i] = sum;
                    }
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", nums)}]");
                    return;
                }
            }
        }
    }
}
