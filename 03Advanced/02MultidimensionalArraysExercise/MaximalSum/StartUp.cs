namespace MaximalSum
{
    using System.Linq;
    using System;
    class StartUp
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int coordOne = 0, coordTwo = 0, bestSum = 0;
            for (int i = 0; i < matrixSize[0]; i++)
            {
                int[] matrixRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = matrixRow[j];
                }
            }
            for (int i = 0; i < matrixSize[0] - 2; i++)
            {
                for (int j = 0; j < matrixSize[1] - 2; j++)
                {
                    int sum = 0;
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            sum += matrix[k, l];
                        }
                    }
                    if (bestSum < sum)
                    {
                        coordOne = i;
                        coordTwo = j;
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine($"Sum = {bestSum}");
            for (int i = coordOne; i < coordOne + 3; i++)
            {
                for (int j = coordTwo; j < coordTwo + 3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}