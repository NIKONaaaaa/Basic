namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (input.Contains(bomb[0]))
            {
                input.RemoveRange(Math.Max(input.IndexOf(bomb[0]) - bomb[1], 0), Math.Min(bomb[1] * 2 + 1, input.Count - Math.Max(input.IndexOf(bomb[0]) - bomb[1], 0)));
            }
            Console.WriteLine(input.Sum());
        }
    }
}