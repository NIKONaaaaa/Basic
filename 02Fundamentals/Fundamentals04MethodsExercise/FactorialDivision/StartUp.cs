namespace FactorialDivision
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Division(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            static void Division(int a, int b)
            {
                Console.WriteLine($"{Factorial(a) / Factorial(b):f2}");
            }
            static double Factorial(int a)
            {
                double sum = 1;
                if (1 < a) for (int i = 1; i <= a; i++) sum *= i;
                return sum;
            }
        }
    }
}