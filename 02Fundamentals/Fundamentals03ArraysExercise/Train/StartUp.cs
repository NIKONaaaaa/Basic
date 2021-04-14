namespace Train
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine()), sum = 0;
            int[] train = new int[number];
            for (int i = 0; i < number; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }
            for (int j = 0; j < number; j++)
            {
                Console.Write($"{train[j]} ");
            }
            Console.WriteLine($"\n{sum}");
        }
    }
}