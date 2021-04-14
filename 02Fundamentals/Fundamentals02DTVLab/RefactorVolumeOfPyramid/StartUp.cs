namespace RefactorVolumeOfPyramid
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write($"Pyramid Volume: {(length * width * height) / 3:f2}");
        }
    }
}