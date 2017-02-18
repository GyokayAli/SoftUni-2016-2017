namespace _01.ConvertBase10ToBaseN
{
    using System;
    using System.Numerics;
    public class ConvertBase10ToBaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            
            var toBase = int.Parse(input[0]);
            var num = BigInteger.Parse(input[1]);

            var result = string.Empty;
            while (num > 0)
            {
                var remainder = num % toBase;
                result = remainder + result;
                num /= toBase;
            }

            Console.WriteLine(result);
        }
    }
}
