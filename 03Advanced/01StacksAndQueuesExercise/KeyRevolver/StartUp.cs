namespace KeyRevolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int revolverCapacity = int.Parse(Console.ReadLine());
            int shotCounter = 0;
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int intelligenceValue = int.Parse(Console.ReadLine());
            while (0 < bullets.Count && 0 < locks.Count)
            {
                if (bullets.Pop() <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                shotCounter++;
                if (shotCounter % revolverCapacity == 0 && 0 < bullets.Count)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            Console.WriteLine(locks.Count > 0
                ? $"Couldn't get through. Locks left: {locks.Count}"
                : $"{bullets.Count} bullets left. Earned ${intelligenceValue - shotCounter * bulletPrice}");
        }
    }
}