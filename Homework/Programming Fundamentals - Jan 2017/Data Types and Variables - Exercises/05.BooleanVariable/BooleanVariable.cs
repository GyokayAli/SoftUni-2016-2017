using System;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}
