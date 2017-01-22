using System;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine($"Before:\na = {num1}\nb = {num2}");

            //Swap logic
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After:\na = {num1}\nb = {num2}");
        }
    }
}
