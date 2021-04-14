namespace MathOperations
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double one = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            double two = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Operation(one, operand, two)}");
            static double Operation(double a, char op, double b)
            {
                if (op == '/') return a / b;
                else if (op == '*') return a * b;
                else if (op == '+') return a + b;
                else return a - b;
            }
        }
    }
}