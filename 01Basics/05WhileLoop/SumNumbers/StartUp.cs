namespace SumNumbers
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;
            while (counter > sum)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}