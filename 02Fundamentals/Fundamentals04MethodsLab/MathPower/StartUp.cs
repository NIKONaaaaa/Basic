namespace MathPower
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerCalc(number, power));
            static double PowerCalc(double x, int n)
            {
                return Math.Pow(x, n);
            }
        }
    }
}