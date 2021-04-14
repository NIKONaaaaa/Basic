namespace Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> trainPassengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacityMax = int.Parse(Console.ReadLine());
            string[] commandInput = Console.ReadLine().Split();
            while (commandInput[0] != "end")
            {
                if (commandInput[0] == "Add")
                {
                    trainPassengers.Add(int.Parse(commandInput[1]));
                }
                else if (commandInput[0] != "end")
                {
                    for (int i = 0; i < trainPassengers.Count; i++)
                    {
                        if (int.Parse(commandInput[0]) + trainPassengers[i] <= wagonCapacityMax)
                        {
                            trainPassengers[i] += int.Parse(commandInput[0]);
                            break;
                        }
                    }
                }
                commandInput = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", trainPassengers));
        }
    }
}