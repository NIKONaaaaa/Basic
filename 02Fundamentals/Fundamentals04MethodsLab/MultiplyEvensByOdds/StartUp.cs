namespace MultiplyEvensByOdds
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(Multiply(Math.Abs(int.Parse(Console.ReadLine()))));
            static int Multiply(int number)
            {
                int sumEven = 0, sumOdd = 0;
                while (number != 0)
                {
                    int digit = number % 10;
                    if (digit % 2 == 0) sumEven += digit;
                    else sumOdd += digit;
                    number /= 10;
                }
                return sumEven * sumOdd;
            }
        }
    }
}