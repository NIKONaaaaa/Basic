namespace AreaofFigures
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string figuretype = Console.ReadLine();
            if (figuretype == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double sqarea = side * side;
                Console.WriteLine($"{sqarea:f3}");
            }
            if (figuretype == "rectangle")
            {
                double height = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double rarea = height * width;
                Console.WriteLine($"{rarea:f3}");
            }
            if (figuretype == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double carea = radius * radius * Math.PI;
                Console.WriteLine($"{carea:f3}");
            }
            if (figuretype == "triangle")
            {
                double tbase = double.Parse(Console.ReadLine());
                double theight = double.Parse(Console.ReadLine());
                double tarea = tbase * theight / 2;
                Console.WriteLine($"{tarea:f3}");
            }
        }
    }
}