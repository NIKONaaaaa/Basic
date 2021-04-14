namespace InchesToCentimeters
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.Write("Enter inches: ");
            double inches = double.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.WriteLine($"Inches equals {cm} centimetres.");
        }
    }
}