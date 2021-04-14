namespace CharacterMultiplier
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(Multiply(input[0], input[1]));
        }
        static int Multiply(string one, string two)
        {
            int sum = 0, lengthOne = one.Length, lengthTwo = two.Length;
            for (int i = 0; i < Math.Min(lengthOne, lengthTwo); i++)
            {
                sum += one[i] * two[i];
            }
            if (lengthOne < lengthTwo)
            {
                for (int i = lengthOne; i < lengthTwo; i++)
                {
                    sum += two[i];
                }
            }
            else if (lengthOne > lengthTwo)
            {
                for (int i = lengthTwo; i < lengthOne; i++)
                {
                    sum += one[i];
                }
            }
            return sum;
        }
    }
}