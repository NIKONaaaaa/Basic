namespace EqualSumsEvenOddPosition
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            for (int i = numberOne; i <= numberTwo; i++)
            {
                string numberCurrent = i.ToString();
                int sumEven = 0;
                int sumOdd = 0;
                for (int j = 0; j < numberCurrent.Length; j++)
                {
                    int digitCurrent = int.Parse(numberCurrent[j].ToString());
                    if (j % 2 == 0)
                    {
                        sumEven += digitCurrent;
                    }
                    else
                    {
                        sumOdd += digitCurrent;
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}