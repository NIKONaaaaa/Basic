namespace SumMatrixColumns
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string matrixSize = Console.ReadLine();
            int rows = matrixSize.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()[0];
            int columns = matrixSize.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()[1];
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                int[] matrixElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = matrixElements[j];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                int sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}