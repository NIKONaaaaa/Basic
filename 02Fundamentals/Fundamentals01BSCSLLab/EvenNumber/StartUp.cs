namespace EvenNumber
{
    using System;
    class StartUp
    {
        static void Main()
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
            }
        }
    }
}