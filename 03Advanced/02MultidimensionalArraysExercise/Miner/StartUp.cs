namespace Miner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            Queue<string> directions = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            char[,] matrix = new char[matrixSize, matrixSize];
            int coalLeft = 0;
            int x = 0, y = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    if (input[j] == 'c')
                    {
                        coalLeft++;
                    }
                    if (input[j] == 's')
                    {
                        x = i;
                        y = j;
                    }
                    matrix[i, j] = input[j];
                }
            }
            while (0 < directions.Count && 0 < coalLeft && matrix[x, y] != 'e')
            {
                switch (directions.Dequeue())
                {
                    case "up" when x - 1 >= 0:
                        x--;
                        break;
                    case "down" when x + 1 < matrix.GetLength(0):
                        x++;
                        break;
                    case "left" when y - 1 >= 0:
                        y--;
                        break;
                    case "right" when y + 1 < matrix.GetLength(1):
                        y++;
                        break;
                }
                if (matrix[x, y] == 'c')
                {
                    matrix[x, y] = '*';
                    coalLeft--;
                }
            }
            if (matrix[x, y] == 'e')
            {
                Console.WriteLine($"Game over! ({x}, {y})");
            }
            else if (coalLeft == 0)
            {
                Console.WriteLine($"You collected all coals! ({x}, {y})");
            }
            else if (directions.Count == 0)
            {
                Console.WriteLine($"{coalLeft} coals left. ({x}, {y})");
            }
        }
    }
}