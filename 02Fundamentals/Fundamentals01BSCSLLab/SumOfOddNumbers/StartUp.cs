namespace SumOfOddNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                    sum += 2 * i - 1;
                    Console.WriteLine(2 * i - 1);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}