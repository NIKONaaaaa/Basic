namespace PrimaryDiagonal
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
                int[] matrixElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = matrixElements[j];
                }
            }
            int sum = 0;
            for (int i = 0, j = 0; i < matrixSize; i++, j++)
            {
                sum += matrix[i, j];
            }
            Console.WriteLine(sum);
        }
    }
}