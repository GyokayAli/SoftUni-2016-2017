using System;

namespace _04.VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            int hexToDecimal = Convert.ToInt32(hex, 16);

            Console.WriteLine(hexToDecimal);
        }
    }
}
