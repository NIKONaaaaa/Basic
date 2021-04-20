namespace PointOnRectangleBorder
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool xCheck = (x == x1 || x == x2) && (y1 <= y && y <= y2);
            bool yCheck = (y == y1 || y == y2) && (x1 <= x && x <= x2);
            if (xCheck || yCheck)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}