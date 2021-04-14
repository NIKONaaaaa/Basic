namespace TownInfo
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string townName = Console.ReadLine();
            int townPop = int.Parse(Console.ReadLine());
            int townArea = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {townPop} and area {townArea} square km.");
        }
    }
}