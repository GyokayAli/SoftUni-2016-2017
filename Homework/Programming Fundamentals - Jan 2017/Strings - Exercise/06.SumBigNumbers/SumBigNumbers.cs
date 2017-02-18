namespace _06.SumBigNumbers
{
    using System;
    using System.Linq;

    public class SumBigNumbers
    {
        public static void Main()
        {
            string numAsString1 = Console.ReadLine();
            string numAsString2 = Console.ReadLine();

            var result = SumNumbers(numAsString1, numAsString2);

            Console.WriteLine(result);
        }

        public static string SumNumbers(string num1, string num2)
        {
            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength + 1, '0');
            num2 = num2.PadLeft(maxLength + 1, '0');

            int[] numArray1 = num1.Select(x => int.Parse(x.ToString())).ToArray();
            int[] numArray2 = num2.Select(x => int.Parse(x.ToString())).ToArray();

            int[] sumOfArrays = new int[numArray1.Length];

            int carry = 0;
            for (int i = sumOfArrays.Length - 1; i >= 0; i--)
            {
                int total = numArray1[i] + numArray2[i] + carry;
                sumOfArrays[i] = total % 10;

                if (total > 9) carry = 1;
                else carry = 0;
            }
            return string.Join("", sumOfArrays.SkipWhile(x => x == 0));
        }
    }
}
