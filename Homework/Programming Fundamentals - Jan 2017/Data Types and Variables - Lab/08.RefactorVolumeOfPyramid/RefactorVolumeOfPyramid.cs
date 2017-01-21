using System;

namespace _08.RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double height = double.Parse(Console.ReadLine());

            double pyramidVolume = (length + width + height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);
        }
    }
}
