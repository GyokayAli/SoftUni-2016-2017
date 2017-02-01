namespace _06.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            Array.Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
