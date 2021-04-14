namespace FoldAndSum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            int[] arrayInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] arrayFolded = new int[2, arrayInput.Length / 2];
            int positionFolded = 0;
            for (int i = arrayInput.Length / 4 - 1; i >= 0; i--)
            {
                arrayFolded[0, positionFolded] = arrayInput[i];
                positionFolded++;
            }
            for (int i = arrayInput.Length - 1; i >= arrayInput.Length - 1 - (arrayInput.Length / 4 - 1); i--)
            {
                arrayFolded[0, positionFolded] = arrayInput[i];
                positionFolded++;
            }
            positionFolded = 0;
            for (int i = arrayInput.Length / 4; i < arrayInput.Length / 4 * 3; i++)
            {
                arrayFolded[1, positionFolded] = arrayInput[i];
                positionFolded++;
            }
            for (int i = 0; i < arrayInput.Length / 2; i++)
            {
                Console.Write($"{arrayFolded[0, i] + arrayFolded[1, i]} ");
            }
        }
    }
}