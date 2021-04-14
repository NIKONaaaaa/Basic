namespace SymbolInMatrix
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            int[] index = {0, 0};
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        index[0] = i;
                        index[1] = j;
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            Console.WriteLine(!found ? $"{symbol} does not occur in the matrix" : $"({index[0]}, {index[1]})");
        }
    }
}