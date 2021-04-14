namespace JaggedArrayManipulator
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] array = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }
            for (int i = 0; i < rows - 1; i++)
            {
                if (array[i].Length == array[i + 1].Length)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *=  2;
                        array[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] /= 2;
                    }
                    for (int j = 0; j < array[i + 1].Length; j++)
                    {
                        array[i + 1][j] /= 2;
                    }
                }
            }
            string commandInput = Console.ReadLine();
            while (commandInput != "End")
            {
                string[] command = commandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "Add" && ValidateIndex(int.Parse(command[1]), int.Parse(command[2]), array))
                {
                    array[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                }
                else if (command[0] == "Subtract" && ValidateIndex(int.Parse(command[1]), int.Parse(command[2]), array))
                {
                    array[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                }
                commandInput = Console.ReadLine();
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", array[i]));
            }
        }
        public static bool ValidateIndex(int indexOne, int indexTwo, double[][] array)
        {
            bool valid = 0 <= indexOne && indexOne < array.GetLength(0);
            if (valid) valid = 0 <= indexTwo && indexTwo < array[indexOne].Length;
            return valid;
        }
    }
}