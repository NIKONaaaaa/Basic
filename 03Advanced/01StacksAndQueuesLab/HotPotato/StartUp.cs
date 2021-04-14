namespace HotPotato
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            Queue<string> kidsQueue = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            int passes = int.Parse(Console.ReadLine()), passesCount = 1;
            while (1 < kidsQueue.Count)
            {
                if (passesCount == passes)
                {
                    Console.WriteLine("Removed " + kidsQueue.Dequeue());
                    passesCount = 1;
                }
                else
                {
                    kidsQueue.Enqueue(kidsQueue.Dequeue());
                    passesCount++;
                }
            }
            Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
        }
    }
}