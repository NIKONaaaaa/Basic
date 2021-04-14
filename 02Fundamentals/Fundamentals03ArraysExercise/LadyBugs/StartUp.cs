namespace LadyBugs
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugIndex = Console.ReadLine().Split().Select(int.Parse).ToArray(), field = new int[fieldSize];
            for (int i = 0; i < field.Length; i++)
            {
                if (ladybugIndex.Contains(i)) field[i] = 1;
            }
            string[] commandInput = Console.ReadLine().Split();
            while (commandInput[0] != "end")
            {
                int index = int.Parse(commandInput[0]), range = int.Parse(commandInput[2]);
                string direction = commandInput[1];
                if ((index >= 0) && (index < fieldSize) && (field[index] == 1))
                {
                    field[index] = 0;
                    if (direction == "right")
                    {
                        while ((index + range < fieldSize) && (index + range >= 0))
                        {
                            if (field[index + range] == 0)
                            {
                                field[index + range] = 1;
                                break;
                            }
                            else
                            {
                                index += range;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        while ((index - range >= 0) && (index - range < fieldSize))
                        {
                            if (field[index - range] == 0)
                            {
                                field[index - range] = 1;
                                break;
                            }
                            else
                            {
                                index -= range;
                            }
                        }
                    }
                    else
                    {
                        field[index] = 1;
                    }
                }
                commandInput = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', field));
        }
    }
}