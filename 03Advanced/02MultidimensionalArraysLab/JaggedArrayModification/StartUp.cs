namespace JaggedArrayModification
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                int row = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                int col = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
                int value = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3]);
                if (0 <= row && row < rows && 0 <= col && col < jaggedArray[row].Length)
                {
                    if (cmd == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }
    }
}