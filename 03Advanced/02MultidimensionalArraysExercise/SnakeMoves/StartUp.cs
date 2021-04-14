namespace SnakeMoves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            Queue<char> snake = new Queue<char>(Console.ReadLine().ToCharArray());
            for (int i = 0; i < matrixSize[0]; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrixSize[1]; j++)
                    {
                        matrix[i, j] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());
                    }
                }
                else
                {
                    for (int j = matrixSize[1] - 1; j >= 0; j--)
                    {
                        matrix[i, j] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());
                    }
                }
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}