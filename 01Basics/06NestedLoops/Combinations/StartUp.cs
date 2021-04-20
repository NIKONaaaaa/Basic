namespace Combinations
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int comboCount = 0;
            for (int x = 0; x <= number; x++)
            {
                for (int y = 0; y <= number; y++)
                {
                    for (int z = 0; z <= number; z++)
                    {
                        if (x + y + z == number)
                        {
                            comboCount++;
                        }
                    }
                }
            }
            Console.WriteLine(comboCount);
        }
    }
}