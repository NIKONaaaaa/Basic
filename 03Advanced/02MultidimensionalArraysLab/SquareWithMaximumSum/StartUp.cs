namespace SquareWithMaximumSum
{
    using System.Linq;
    using System;
    class StartUp
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int coordOne = 0, coordTwo = 0, squareSum = 0;
            for (int i = 0; i < matrixSize[0]; i++)
            {
                int[] matrixRow = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = matrixRow[j];
                }
            }
            for (int i = 0; i < matrixSize[0] - 1; i++)
            {
                for (int j = 0; j < matrixSize[1] - 1; j++)
                {
                    int numOne = matrix[i, j];
                    int numTwo = matrix[i, j + 1];
                    int numThree = matrix[i + 1, j];
                    int numFour = matrix[i + 1, j + 1];
                    int sum = numOne + numTwo + numThree + numFour;
                    if (squareSum < sum && !(coordOne > i))
                    {
                        coordOne = i;
                        coordTwo = j;
                        squareSum = sum;
                    }
                }
            }
            Console.WriteLine($"{matrix[coordOne, coordTwo]} {matrix[coordOne, coordTwo + 1]}");
            Console.WriteLine($"{matrix[coordOne + 1, coordTwo]} {matrix[coordOne + 1, coordTwo + 1]}");
            Console.WriteLine(squareSum);
        }
    }
}