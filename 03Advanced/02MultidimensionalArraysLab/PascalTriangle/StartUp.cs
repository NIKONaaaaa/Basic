namespace PascalTriangle
{
    using System;
    using System.Numerics;
    class StartUp
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            BigInteger currentNumber = 1;
            for (int positionRight = 0; positionRight < length; positionRight++)
            {
                for (int positionLeft = 0; positionLeft <= positionRight; positionLeft++)
                {
                    if (positionLeft == 0 || positionRight == 0)
                    {
                        currentNumber = 1;
                    }
                    else
                    {
                        currentNumber = currentNumber * (positionRight - positionLeft + 1) / positionLeft;
                    }
                    Console.Write($"{currentNumber} ");
                }
                Console.Write("\n");
            }
        }
    }
}