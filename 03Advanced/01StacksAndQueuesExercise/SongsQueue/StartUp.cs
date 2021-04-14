namespace SongsQueue
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
            while (0 < songs.Count)
            {
                string command = Console.ReadLine();
                if (command.Substring(0, 4) == "Play")
                {
                    songs.Dequeue();
                }
                else if (command.Substring(0, 3) == "Add")
                {
                    if (songs.Contains(command[4..]))
                    {
                        Console.WriteLine($"{command[4..]} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(command[4..]);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}