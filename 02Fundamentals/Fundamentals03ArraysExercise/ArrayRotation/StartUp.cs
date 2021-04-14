namespace ArrayRotation
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(), temp = new int[1];
            int rotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotation; i++)
            {
                temp[0] = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[^1] = temp[0];
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}