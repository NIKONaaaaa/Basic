namespace FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int foodPrepared = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Console.WriteLine(orders.Prepend(int.MinValue).Max());
            while (0 < orders.Count)
            {
                if (orders.Peek() <= foodPrepared)
                {
                    foodPrepared -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(orders.Count == 0 ? "Orders complete" : $"Orders left: {string.Join(" ", orders)}");
        }
    }
}