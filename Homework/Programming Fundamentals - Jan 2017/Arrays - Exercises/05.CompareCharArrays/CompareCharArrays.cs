namespace _05.CompareCharArrays
{
    using System;
    using System.Linq;

    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int min = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < min; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                    break;
                }
                else if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                    break;
                }
                else if (arr1.Length == arr2.Length && arr1[i] == arr2[i])
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2); 
                    break;
                }
                else if (arr1.Length != arr2.Length && arr1[i] == arr2[i])
                {
                    Console.WriteLine(arr1.Length > arr2.Length ? arr2 : arr1);
                    Console.WriteLine(arr1.Length < arr2.Length ? arr2 : arr1);
                    break;
                }
            }
        }
    }
}