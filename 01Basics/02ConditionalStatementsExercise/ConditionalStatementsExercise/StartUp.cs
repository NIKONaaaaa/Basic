namespace SumSeconds
{ 
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int totaltime = 0;
            totaltime += int.Parse(Console.ReadLine());
            totaltime += int.Parse(Console.ReadLine());
            totaltime += int.Parse(Console.ReadLine());
            int minutes = totaltime / 60;
            int seconds = totaltime % 60;
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}