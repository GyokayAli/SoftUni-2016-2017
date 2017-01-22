using System;

namespace _17.PrintPartlyASCIITable
{
    class PrintPartlyASCIITable
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for(int i = startNum; i <= endNum; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
