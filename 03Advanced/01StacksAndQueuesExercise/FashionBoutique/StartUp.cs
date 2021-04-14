namespace FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine()), rackCount = 0, currentRack = 0;
            while (0 < clothes.Count)
            {
                if (clothes.Peek() + currentRack > rackCapacity)
                {
                    rackCount++;
                    currentRack = 0;
                }
                else if (clothes.Peek() + currentRack == rackCapacity)
                {
                    rackCount++;
                    currentRack -= rackCapacity;
                }
                currentRack += clothes.Pop();
            }
            if (currentRack > 0)
            {
                rackCount++;
            }
            Console.WriteLine(rackCount);
        }
    }
}