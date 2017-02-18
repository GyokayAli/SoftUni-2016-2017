namespace _07.MultiplyBigNumbers
{
    using System;
    using System.Linq;

    public class MultiplyBigNumbers
    {
        public static void Main()
        {
            string numAsString = Console.ReadLine();
            int multiply = int.Parse(Console.ReadLine());

            if(multiply != 0)
            {
                numAsString = numAsString.PadLeft(numAsString.Length + 1, '0');

                int[] numArray = numAsString.Select(x => int.Parse(x.ToString())).ToArray();
                int[] sum = new int[numArray.Length];
                int carry = 0;
                for (int i = numAsString.Length - 1; i >= 0; i--)
                {
                    int total = numArray[i] * multiply + carry;
                    sum[i] = total % 10;

                    if (total > 9) carry = total / 10;
                    else carry = 0;
                }
                Console.WriteLine(string.Join("", sum.SkipWhile(x => x == 0)));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
