namespace DiagonalDifference
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                int[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int primarySum = 0, secondarySum = 0;
            for (int i = 0, j = 0; i < matrixSize; i++, j++)
            {
                primarySum += matrix[i, j];
            }
            for (int i = 0, j = matrixSize - 1; i < matrixSize; i++, j--)
            {
                secondarySum += matrix[i, j];
            }
            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}