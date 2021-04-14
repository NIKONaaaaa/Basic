namespace ReverseStrings
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<string> output = new Stack<string>();
            foreach (char ch in input)
            {
                output.Push(ch.ToString());
            }
            while (0 < output.Count)
            {
                Console.Write(output.Pop());
            }
        }
    }
}