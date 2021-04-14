namespace FloatingEquality
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double one = double.Parse(Console.ReadLine()), two = double.Parse(Console.ReadLine());
            if (Math.Abs(one - two) < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}