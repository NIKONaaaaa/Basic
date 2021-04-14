namespace MatchingBrackets
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> indices = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indices.Push(i);
                }
                if (input[i] == ')')
                {
                    Console.WriteLine(input.Substring(indices.Peek(), i - indices.Pop() + 1));
                }
            }
        }
    }
}