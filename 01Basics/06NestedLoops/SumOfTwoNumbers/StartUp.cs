namespace SumOfTwoNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberSum = int.Parse(Console.ReadLine());
            int comboCount = 0;
            bool comboCheck = false;
            for (int i = numberOne; i <= numberTwo; i++)
            {
                for (int j = numberOne; j <= numberTwo; j++)
                {
                    comboCount++;
                    if (i + j == numberSum && comboCheck == false)
                    {
                        Console.WriteLine($"Combination N:{comboCount} ({i} + {j} = {numberSum})");
                        comboCheck = true;
                        break;
                    }
                    else if (i == numberTwo && j == numberTwo && comboCheck == false)
                    {
                        Console.WriteLine($"{comboCount} combinations - neither equals {numberSum}");
                    }
                }
            }
        }
    }
}