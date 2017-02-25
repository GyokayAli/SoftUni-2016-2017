namespace _02.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();
            while (command != "end")
            {
                var splitCommands = command.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (splitCommands[0])
                {
                    case "reverse": Reverse(numbers, int.Parse(splitCommands[2]), int.Parse(splitCommands[4])); break;
                    case "sort": Sort(numbers, int.Parse(splitCommands[2]), int.Parse(splitCommands[4])); break;
                    case "rollLeft": RollLeft(numbers, int.Parse(splitCommands[1])); break;
                    case "rollRight": RollRight(numbers, int.Parse(splitCommands[1])); break;
                }
                command = Console.ReadLine();
            }
            Console.Write($"[" + string.Join(", ", numbers) + "]");
        }

        private static void RollRight(List<string> numbers, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            int listLength = numbers.Count;
            int realRoll = count % listLength;
            for (int i = 0; i < realRoll; i++)
            {
                numbers.Insert(0, numbers[listLength - 1]);
                numbers.RemoveAt(listLength);
            }
        }

        private static void RollLeft(List<string> numbers, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            int realRoll = count % numbers.Count;
            for (int i = 0; i < realRoll; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        private static void Sort(List<string> numbers, int start, int count)
        {
            int listLength = numbers.Count;
            if (start < 0 || count < 0 || start >= listLength || start + count - 1 >= listLength)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            numbers.Sort(start, count, StringComparer.InvariantCulture);
        }

        private static void Reverse(List<string> numbers, int start, int count)
        {
            int listLength = numbers.Count;
            if (start < 0 || count < 0 || start >= listLength || start + count - 1 >= listLength)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            numbers.Reverse(start, count);
        }
    }
}
