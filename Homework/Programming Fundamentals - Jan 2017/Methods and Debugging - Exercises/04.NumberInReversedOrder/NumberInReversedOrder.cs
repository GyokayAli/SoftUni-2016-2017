namespace _04.NumberInReversedOrder
{
    using System;
    using System.Linq;

    class NumberInReversedOrder
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            PrintReversed(num);
        }

        static void PrintReversed(decimal num)
        {
            char[] charArr = num.ToString().ToCharArray();
            Array.Reverse(charArr);
            decimal reversed = decimal.Parse(new string(charArr));

            Console.WriteLine(reversed);
        }
    }
}
