namespace RefactoringPrimeChecker
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int max = int.Parse(Console.ReadLine());
            for (int number = 2; number <= max; number++)
            {
                bool checkPrime = true;
                if (number == 2)
                {
                    checkPrime = true;
                }
                else if (number % 2 == 0)
                {
                    checkPrime = false;
                }
                int divisor = (int)Math.Round(Math.Sqrt(number));
                for (int i = 3; i <= divisor; i += 2)
                {
                    if (checkPrime == false)
                    {
                        break;
                    }
                    if (number % i == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }
                if (checkPrime)
                {
                    Console.WriteLine($"{number} -> true");
                }
                else
                {
                    Console.WriteLine($"{number} -> false");
                }
            }
        }
    }
}