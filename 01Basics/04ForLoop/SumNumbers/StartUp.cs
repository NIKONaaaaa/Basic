namespace SumNumbers
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberAmount = int.Parse(Console.ReadLine());
            int numberTotal = 0;
            for (int i = 1; i <= numberAmount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numberTotal += number;
            }
            Console.WriteLine(numberTotal);
        }
    }
}