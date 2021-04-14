namespace CupsAndBottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wasteWater = 0;
            while (0 < cups.Count && 0 < bottles.Count)
            {
                int cup = cups.Dequeue();
                int bottle = bottles.Pop();
                while (cup > bottle && bottles.Count > 0)
                {
                    cup -= bottle;
                    bottle = bottles.Pop();
                }
                wasteWater += bottle - cup;
            }
            if (cups.Count > 0)
            {
                Console.WriteLine("Cups: " + string.Join(" ", cups));
            }
            else
            {
                Console.WriteLine("Bottles: " + string.Join(" ", bottles));
            }
            Console.WriteLine($"Wasted litters of water: {wasteWater}");
        }
    }
}