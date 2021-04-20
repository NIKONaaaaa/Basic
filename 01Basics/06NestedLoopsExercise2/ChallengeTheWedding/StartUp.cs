namespace ChallengeTheWedding
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int combo = 0;
            bool check = false;
            for (int j = 1; j <= men; j++)
            {
                for (int i = 1; i <= women; i++)
                {
                    Console.Write($"({j} <-> {i}) ");
                    combo++;
                    if (combo == tables)
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    break;
                }
            }
        }
    }
}