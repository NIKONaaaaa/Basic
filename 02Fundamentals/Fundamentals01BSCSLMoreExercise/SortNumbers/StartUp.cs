namespace SortNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}