namespace NumberSequence
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberLowest = int.MaxValue;
            int numberHighest = int.MinValue;
            int numberCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number <= numberLowest)
                {
                    numberLowest = number;
                }
                if (number >= numberHighest)
                {
                    numberHighest = number;
                }
            }
            Console.WriteLine($"Max number: {numberHighest}");
            Console.WriteLine($"Min number: {numberLowest}");
        }
    }
}