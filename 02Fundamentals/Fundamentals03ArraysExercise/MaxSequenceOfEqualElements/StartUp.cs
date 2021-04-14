namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sequenceCurrent = 0, sequenceMax = 0, number = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    sequenceCurrent++;
                    if (sequenceMax < sequenceCurrent)
                    {
                        sequenceMax = sequenceCurrent;
                        number = numbers[i];
                    }
                }
                else
                {
                    sequenceCurrent = 0;
                }
            }
            for (int i = 0; i <= sequenceMax; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}