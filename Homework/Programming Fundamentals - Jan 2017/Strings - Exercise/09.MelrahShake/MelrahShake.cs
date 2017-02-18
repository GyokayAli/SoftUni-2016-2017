namespace _09.MelrahShake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            var fullLine = Console.ReadLine();
            var key = Console.ReadLine();

            while (true)
            {
                int firstindex = fullLine.IndexOf(key);
                int lastindex = fullLine.LastIndexOf(key);

                if (firstindex != -1 && lastindex != -1 && firstindex != lastindex && key.Length > 0)
                {
                    Console.WriteLine("Shaked it.");
                    fullLine = fullLine.Remove(firstindex, key.Length);
                    lastindex = fullLine.LastIndexOf(key);
                    fullLine = fullLine.Remove(lastindex, key.Length);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(fullLine);
                    break;
                }

                var indexToRemove = key.Length / 2;
                key = key.Remove(indexToRemove, 1);
            }
        }
    }
}
