namespace LongerLine
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine()), x2 = double.Parse(Console.ReadLine()), y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine()), y3 = double.Parse(Console.ReadLine()), x4 = double.Parse(Console.ReadLine()), y4 = double.Parse(Console.ReadLine());
            Console.WriteLine(CompareLineLength(x1, y1, x2, y2, x3, y3, x4, y4));
        }
        static string CompareLineLength(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lineOneLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lineTwoLength = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            if (lineOneLength >= lineTwoLength)
            {
                if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) <= Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
                {
                    return ($"({x1}, {y1})({x2}, {y2})");
                }
                return ($"({x2}, {y2})({x1}, {y1})");
            }
            if (Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2)) <= Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2)))
            {
                return ($"({x3}, {y3})({x4}, {y4})");
            }
            return ($"({x4}, {y4})({x3}, {y3})");
        }
    }
}