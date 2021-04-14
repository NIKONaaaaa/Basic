namespace PrintNumbersInReverseOrder
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            int[] numbers = new int[counter];
            for (int i = counter - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}