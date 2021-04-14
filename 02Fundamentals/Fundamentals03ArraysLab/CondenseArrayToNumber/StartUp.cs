namespace CondenseArrayToNumber
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                while (1 < input.Length)
                {
                    int[] condensed = new int[input.Length - 1];
                    for (int i = 0; i < input.Length - 1; i++)
                    {
                        condensed[i] = input[i] + input[i + 1];
                    }
                    input = condensed;
                }
                Console.WriteLine(input[0]);
            }
        }
    }
}