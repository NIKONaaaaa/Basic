namespace PrintAndSum
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = numberOne; i <= numberTwo; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\nSum: {sum}");
        }
    }
}