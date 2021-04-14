namespace EvenAndOddSubtraction
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sumEven = 0, sumOdd = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    sumEven += input[i];
                }
                else
                {
                    sumOdd += input[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}