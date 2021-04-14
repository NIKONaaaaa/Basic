namespace RoundingNumbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Math.Round(Convert.ToDecimal(numbers[i]), MidpointRounding.AwayFromZero)}");
            }
        }
    }
}