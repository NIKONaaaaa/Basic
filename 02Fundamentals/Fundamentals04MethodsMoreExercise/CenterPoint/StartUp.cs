namespace CenterPoint
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine()), x2 = double.Parse(Console.ReadLine()), y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(ComputeDistance(x1, y1, x2, y2));
        }
        static string ComputeDistance(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) <= Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
            {
                return ($"({x1}, {y1})");
            }
            return ($"({x2}, {y2})");
        }
    }
}