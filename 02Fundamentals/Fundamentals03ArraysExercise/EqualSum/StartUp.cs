namespace EqualSum
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool check = true;
            if (input.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int sumLeft = 0, sumRight = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += input[j];
                    }
                    for (int j = 1 + i; j < input.Length; j++)
                    {
                        sumRight += input[j];
                    }
                    if (sumLeft == sumRight)
                    {
                        Console.WriteLine(i);
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}