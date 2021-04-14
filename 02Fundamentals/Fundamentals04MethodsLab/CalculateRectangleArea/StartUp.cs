namespace CalculateRectangleArea
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine()), height = double.Parse(Console.ReadLine());
            Console.WriteLine(CalcArea(width, height));
            static double CalcArea(double width, double height)
            {
                return width * height;
            }
        }
    }
}