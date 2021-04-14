namespace RecursiveFibonacci
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Int64 fibonacciNumber = int.Parse(Console.ReadLine()), fiOne = 1, fiTwo = 1;
            if (fibonacciNumber == 1 || fibonacciNumber == 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 3; i <= fibonacciNumber; i++)
                {
                    fiTwo = fiOne + fiTwo;
                    fiOne = fiTwo - fiOne;
                }
                Console.WriteLine(fiTwo);
            }
        }
    }
}