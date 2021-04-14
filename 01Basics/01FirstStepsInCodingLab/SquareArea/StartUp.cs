namespace SquareArea
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int side = int.Parse(Console.ReadLine());
            int area = side * side;
            Console.WriteLine(area);
        }
    }
}