namespace Messages
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int[] combo = { 2, 22, 222, 3, 33, 333, 4, 44, 444, 5, 55, 555, 6, 66, 666, 7, 77, 777, 7777, 8, 88, 888, 9, 99, 999, 9999, 0 };
            string[] letter = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " " };
            int characters = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 1; i <= characters; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int index = Array.IndexOf(combo, input);
                message += letter[index];
            }
            Console.WriteLine(message);
        }
    }
}