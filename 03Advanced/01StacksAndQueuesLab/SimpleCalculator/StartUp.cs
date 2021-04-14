namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Stack<string> input = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse());
            int result = 0;
            result += int.Parse(input.Pop());
            while (0 < input.Count)
            {
                if (input.Peek() == "-")
                {
                    input.Pop();
                    result -= int.Parse(input.Pop());
                }
                else
                {
                    input.Pop();
                    result += int.Parse(input.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}