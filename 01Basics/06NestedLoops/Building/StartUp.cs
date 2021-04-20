namespace Building
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int floorCount = int.Parse(Console.ReadLine());
            int roomCount = int.Parse(Console.ReadLine());
            for (int i = floorCount; 1 <= i; i--)
            {
                for (int j = 0; roomCount > j; j++)
                {
                    if (i == floorCount)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}