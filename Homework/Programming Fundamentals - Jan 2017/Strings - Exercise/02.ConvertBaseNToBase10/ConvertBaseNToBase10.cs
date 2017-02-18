namespace _02.ConvertBaseNToBase10
{
    using System;
    using System.Numerics;

    public class ConvertBaseNToBase10
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var toBase = int.Parse(input[0]);
            var numAsString = input[1];

            var sum = new BigInteger(0);
            for (int power = 0; power < numAsString.Length; power++)
            {
                var currNum = int.Parse(numAsString[numAsString.Length - 1 - power].ToString());
                sum += currNum * BigInteger.Pow(toBase, power);
            }

            Console.WriteLine(sum);
        }
    }
}
