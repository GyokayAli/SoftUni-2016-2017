namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            var storageDict = new Dictionary<string, Dictionary<string, long>>();

            var n = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                string[] fileData = input.Last().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var root = input[0];
                var fileName = fileData[0];
                var fileSize = long.Parse(fileData[1]);

                if (storageDict.ContainsKey(root))
                {
                    if (storageDict[root].ContainsKey(fileName))
                    {
                        storageDict[root][fileName] = fileSize;
                    }
                    else
                    {
                        storageDict[root].Add(fileName, fileSize);
                    }
                }
                else
                {
                    storageDict[root] =  new Dictionary<string, long> { { fileName, fileSize } };
                }
            }

            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var extension = command[0];
            var dir = command[2];

            var sorted = storageDict.Where(x => x.Key == dir).OrderByDescending(f => f.Value.Values);

            foreach (var r in sorted)
            {
                foreach (var kvp in r.Value.OrderByDescending(x => x.Value).ThenBy(z => z.Key))
                {
                    if (kvp.Key.Split('.').Last() == extension)
                    {
                        Console.WriteLine($"{kvp.Key} - {kvp.Value} KB");
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
