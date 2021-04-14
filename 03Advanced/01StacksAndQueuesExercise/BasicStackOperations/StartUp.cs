namespace BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int elementRemoveNumber = int.Parse(input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
            int elementTarget = int.Parse(input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
            Stack<int> elements = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            for (int i = 0; i < elementRemoveNumber; i++)
            {
                elements.Pop();
            }
            if (elements.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (elements.Contains(elementTarget))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(elements.Min().ToString());
            }
        }
    }
}