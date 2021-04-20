namespace SumPrimeNonPrime
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int sumPrime = 0;
            int sumNonPrime = 0;
            bool checkPrime;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                if (int.Parse(input) < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    checkPrime = true;
                    if (int.Parse(input) <= 1)
                    {
                        checkPrime = false;
                    }
                    if (int.Parse(input) == 2)
                    {
                        checkPrime = true;
                    }
                    else if (int.Parse(input) % 2 == 0)
                    {
                        checkPrime = false;
                    }
                    int divisor = (int)Math.Round(Math.Sqrt(int.Parse(input)));
                    for (int i = 3; i <= divisor; i += 2)
                    {
                        if (checkPrime == false)
                        {
                            break;
                        }
                        if (int.Parse(input) % i == 0)
                        {
                            checkPrime = false;
                            break;
                        }
                    }
                    if (checkPrime)
                    {
                        sumPrime += int.Parse(input);
                    }
                    else
                    {
                        sumNonPrime += int.Parse(input);
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}