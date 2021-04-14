namespace TopIntegers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var output = new int { };
            for (int i = 0; i < input.Length; i++)
            {
                bool check = true;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}