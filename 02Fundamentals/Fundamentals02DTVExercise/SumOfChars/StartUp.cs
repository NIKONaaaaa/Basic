namespace SumOfChars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine()), sum = 0;
            for (int i = 1; i <= counter; i++)
            {
                sum += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}