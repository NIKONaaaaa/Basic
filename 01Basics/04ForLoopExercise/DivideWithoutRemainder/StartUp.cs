namespace DivideWithoutRemainder
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int totalCounter = int.Parse(Console.ReadLine());
            int numberCounter1 = 0;
            int numberCounter2 = 0;
            int numberCounter3 = 0;
            for (int i = 1; i <= totalCounter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if ((number % 2) == 0)
                {
                    numberCounter1++;
                }
                if ((number % 3) == 0)
                {
                    numberCounter2++;
                }
                if ((number % 4) == 0)
                {
                    numberCounter3++;
                }
            }
            Console.WriteLine($"{(1.0 * numberCounter1 / totalCounter) * 100:f2}%");
            Console.WriteLine($"{(1.0 * numberCounter2 / totalCounter) * 100:f2}%");
            Console.WriteLine($"{(1.0 * numberCounter3 / totalCounter) * 100:f2}%");
        }
    }
}