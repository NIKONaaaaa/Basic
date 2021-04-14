namespace AddAndSubtract
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int one = int.Parse(Console.ReadLine()), two = int.Parse(Console.ReadLine()), three = int.Parse(Console.ReadLine()), sumOneTwo = Sum(one, two);
            Console.WriteLine(Sub(sumOneTwo, three));
            static int Sum(int a, int b)
            {
                return a + b;
            }
            static int Sub(int a, int b)
            {
                return a - b;
            }
        }
    }
}