namespace _03.PrintingTriangle
{
    using System;

    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            //print upper section
            for (int i = 1; i < end; i++)
            {
                PrintLine(1, i);
            }

            //print mid line
            PrintLine(1, end);

            //print bottom section
            for (int i = end - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
