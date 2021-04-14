namespace ExactSumOfRealNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}