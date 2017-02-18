namespace _01.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var reversed = inputString.Reverse();

            Console.WriteLine(string.Join("", reversed));
        }
    }
}
