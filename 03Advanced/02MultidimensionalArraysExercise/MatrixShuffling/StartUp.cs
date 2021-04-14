namespace MatrixShuffling
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            for (int i = 0; i < matrixSize[0]; i++)
            {
                string[] matrixRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = matrixRow[j];
                }
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] != "swap" || command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                if (!ValidateCoordinates(int.Parse(command[1]), int.Parse(command[2]), int.Parse(command[3]), int.Parse(command[4]), matrixSize))
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                string swapper = matrix[int.Parse(command[1]), int.Parse(command[2])];
                matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                matrix[int.Parse(command[3]), int.Parse(command[4])] = swapper;
                for (int i = 0; i < matrixSize[0]; i++)
                {
                    for (int j = 0; j < matrixSize[1]; j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
                input = Console.ReadLine();
            }
        }
        public static bool ValidateCoordinates(int coordinateOne, int coordinateTwo, int coordinateThree, int coordinateFour, int[] size)
        {
            bool valid = 0 <= coordinateOne && coordinateOne < size[0];
            if (valid) valid = 0 <= coordinateTwo && coordinateTwo < size[1];
            if (valid) valid = 0 <= coordinateThree && coordinateThree < size[0];
            if (valid) valid = 0 <= coordinateFour && coordinateFour < size[1];
            return valid;
        }
    }
}