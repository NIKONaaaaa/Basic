namespace MultiplicationTableTwo
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int digit = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{digit} X {i} = {digit * i}");
                }
            }
            else
            {
                Console.WriteLine($"{digit} X {multiplier} = {digit * multiplier}");
            }
        }
    }
}