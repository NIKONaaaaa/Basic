namespace Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> stones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Lake lake = new Lake(stones);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}