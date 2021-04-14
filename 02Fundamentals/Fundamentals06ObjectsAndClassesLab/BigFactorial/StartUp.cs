namespace BigFactorial
{
    using System;
    using System.Numerics;
    class StartUp
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(input));
        }
        private static BigInteger Factorial(BigInteger number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}