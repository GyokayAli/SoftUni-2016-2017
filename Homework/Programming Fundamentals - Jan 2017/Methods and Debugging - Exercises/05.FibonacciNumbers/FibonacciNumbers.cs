namespace _05.FibonacciNumbers
{
    using System;

    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }

        static void Fib(int n)
        {
            int a = 1;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine(a);
        }
    }
}
