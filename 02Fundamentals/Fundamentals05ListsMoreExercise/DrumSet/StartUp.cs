namespace DrumSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            float savings = float.Parse(Console.ReadLine());
            List<int> initialDrumStatus = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> currentDrumStatus = initialDrumStatus.ToList();
            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                for (int i = 0; i < currentDrumStatus.Count; i++)
                {
                    currentDrumStatus[i] -= int.Parse(command);
                    if (currentDrumStatus[i] <= 0 && savings - initialDrumStatus[i] * 3 >= 0)
                    {
                        currentDrumStatus[i] = initialDrumStatus[i];
                        savings -= initialDrumStatus[i] * 3;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (int drum in currentDrumStatus.Where(x => x > 0))
            {
                Console.Write($"{drum} ");
            }
            Console.WriteLine($"\nGabsy has {savings:f2}lv.");
        }
    }
}