using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string bin = Convert.ToString(num, 2);
            string hex = Convert.ToString(num, 16).ToUpper();

            Console.WriteLine($"{hex}\n{bin}");
        }
    }
}
