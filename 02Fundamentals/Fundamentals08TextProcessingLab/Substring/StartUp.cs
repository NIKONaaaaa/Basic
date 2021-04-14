namespace Substring
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string key = Console.ReadLine(), input = Console.ReadLine();
            while (input.Contains(key))
            {
                input = input.Remove(input.IndexOf(key), key.Length);
            }
            Console.WriteLine(input);
        }
    }
}