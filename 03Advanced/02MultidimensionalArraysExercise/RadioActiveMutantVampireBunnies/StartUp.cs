namespace RadioActiveMutantVampireBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            int x = 0, y = 0;
            for (int i = 0; i < size[0]; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size[1]; j++)
                {
                    if (input[j] == 'P')
                    {
                        x = i;
                        y = j;
                    }
                    matrix[i, j] = input[j];
                }
            }
            Queue<char> directions = new Queue<char>(Console.ReadLine().ToCharArray());
            string playerStatus = "alive";
            while (playerStatus == "alive")
            {
                matrix[x, y] = '.';
                int a = x;
                int b = y;
                switch (directions.Dequeue())
                {
                    case 'U':
                        x--;
                        break;
                    case 'D':
                        x++;
                        break;
                    case 'L':
                        y--;
                        break;
                    case 'R':
                        y++;
                        break;
                }
                if (0 > x || x >= matrix.GetLength(0) || 0 > y || y >= matrix.GetLength(1))
                {
                    x = a;
                    y = b;
                    playerStatus = "won";
                }
                else
                {
                    if (matrix[x, y] == '.')
                    {
                        matrix[x, y] = 'P';
                    }
                    else
                    {
                        playerStatus = "dead";
                    }
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (0 <= i - 1 && matrix[i, j] == 'B')
                        {
                            if (matrix[i - 1, j] == 'P')
                            {
                                playerStatus = "dead";
                            }
                            if (matrix[i - 1, j] != 'B')
                            {
                                matrix[i - 1, j] = 'b';
                            }
                        }
                        if (matrix.GetLength(0) > i + 1 && matrix[i, j] == 'B')
                        {
                            if (matrix[i + 1, j] == 'P')
                            {
                                playerStatus = "dead";
                            }
                            if (matrix[i + 1, j] != 'B')
                            {
                                matrix[i + 1, j] = 'b';
                            }
                        }
                        if (0 <= j - 1 && matrix[i, j] == 'B')
                        {
                            if (matrix[i, j - 1] == 'P')
                            {
                                playerStatus = "dead";
                            }
                            if (matrix[i, j - 1] != 'B')
                            {
                                matrix[i, j - 1] = 'b';
                            }
                        }
                        if (matrix.GetLength(1) > j + 1 && matrix[i, j] == 'B')
                        {
                            if (matrix[i, j + 1] == 'P')
                            {
                                playerStatus = "dead";
                            }
                            if (matrix[i, j + 1] != 'B')
                            {
                                matrix[i, j + 1] = 'b';
                            }
                        }
                    }
                }
                for (int i = 0; i < size[0]; i++)
                {
                    for (int j = 0; j < size[1]; j++)
                    {
                        if (matrix[i, j] == 'b')
                        {
                            matrix[i, j] = 'B';
                        }
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{playerStatus}: {x} {y}");
        }
    }
}