namespace EqualArrays
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] arrayOne = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;
            bool check = true;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                sum += arrayOne[i];
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}