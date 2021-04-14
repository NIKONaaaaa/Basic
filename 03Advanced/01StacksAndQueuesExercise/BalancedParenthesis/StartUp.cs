namespace BalancedParenthesis
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            const string open = "{[(", close = "}])";
            bool balanced = true;
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            foreach (char ch in input)
            {
                if (open.Contains(ch))
                {
                    parentheses.Push(ch);
                }
                else
                {
                    if (0 < parentheses.Count && close.IndexOf(ch) == open.IndexOf(parentheses.Peek()))
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        balanced = false;
                        break;
                    }
                }
            }
            if (balanced && parentheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}