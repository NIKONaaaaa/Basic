namespace SquaresInMatrix
{
    using System.Linq;
    using System;
    class StartUp
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            int squareNumber = 0;
            for (int i = 0; i < matrixSize[0]; i++)
            {
                char[] matrixRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = matrixRow[j];
                }
            }
            for (int i = 0; i < matrixSize[0] - 1; i++)
            {
                for (int j = 0; j < matrixSize[1] - 1; j++)
                {
                    char one = matrix[i, j];
                    char two = matrix[i, j + 1];
                    char three = matrix[i + 1, j];
                    char four = matrix[i + 1, j + 1];
                    if (one == two && two == three && three == four)
                    {
                        squareNumber++;
                    }
                }
            }
            Console.WriteLine(squareNumber);
        }
    }
}