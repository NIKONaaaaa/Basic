namespace Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            int cellsAlive = 0, cellSum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            Queue<string> coords = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            while (0 < coords.Count)
            {
                string currCoords = coords.Dequeue();
                int[] hit = new int[2];
                hit[0] = currCoords.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()[0];
                hit[1] = currCoords.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()[1];
                if (matrix[hit[0], hit[1]] > 0)
                {
                    int explosion = matrix[hit[0], hit[1]];
                    for (int i = hit[0] - 1; i <= hit[0] + 1; i++)
                    {
                        for (int j = hit[1] - 1; j <= hit[1] + 1; j++)
                        {
                            bool isValidCoordinate = 0 <= i && 0 <= j && i < matrix.GetLength(0) && j < matrix.GetLength(1);
                            if (isValidCoordinate && matrix[i, j] > 0)
                            {
                                matrix[i, j] -= explosion;
                            }
                        }
                    }
                }
            }
            foreach (int bomb in matrix)
            {
                if (0 < bomb)
                {
                    cellsAlive++;
                    cellSum += bomb;
                }
            }
            Console.WriteLine($"Alive cells: {cellsAlive}\nSum: {cellSum}");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}