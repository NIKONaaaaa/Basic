namespace TribonacciSequence
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] sequence = new int[number];
            sequence[0] = 1;
            if (number == 2)
            {
                sequence[1] = 1;
            }
            else if (number == 3)
            {
                sequence[1] = 1;
                sequence[2] = 2;
            }
            else
            {
                for (int i = 3; i < number; i++)
                {
                    sequence[1] = 1;
                    sequence[2] = 2;
                    sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
                }
            }
            foreach (int tribNumber in sequence)
            {
                Console.Write($"{tribNumber} ");
            }
        }
    }
}