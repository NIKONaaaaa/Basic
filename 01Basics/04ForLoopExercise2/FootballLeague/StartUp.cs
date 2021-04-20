namespace FootballLeague
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fanCount = int.Parse(Console.ReadLine());
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;
            for (int i = 1; i <= fanCount; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                switch (sector)
                {
                    case 'A':
                        sectorA++;
                        break;
                    case 'B':
                        sectorB++;
                        break;
                    case 'V':
                        sectorV++;
                        break;
                    case 'G':
                        sectorG++;
                        break;
                }
            }
            Console.WriteLine($"{100.0 * sectorA / fanCount:f2}%");
            Console.WriteLine($"{100.0 * sectorB / fanCount:f2}%");
            Console.WriteLine($"{100.0 * sectorV / fanCount:f2}%");
            Console.WriteLine($"{100.0 * sectorG / fanCount:f2}%");
            Console.WriteLine($"{100.0 * fanCount / stadiumCapacity:f2}%");
        }
    }
}