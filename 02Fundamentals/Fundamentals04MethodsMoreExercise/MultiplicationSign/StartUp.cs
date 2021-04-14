namespace MultiplicationSign
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(CheckSign(PopulateNumbers()));
        }
        static string CheckSign(int[] numbers)
        {
            if (numbers.Contains(0)) return "zero";
            int negCount = 0;
            foreach (int number in numbers.Where(num => num < 0))
            {
                negCount++;
            }
            if (negCount % 2 == 0) return "positive";
            return "negative";
        }
        static int[] PopulateNumbers()
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
    }
}