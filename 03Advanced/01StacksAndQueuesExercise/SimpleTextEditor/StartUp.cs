namespace SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            Stack<string> savedStates = new Stack<string>();
            int commandNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandNumber; i++)
            {
                string command = Console.ReadLine();
                if (command[0] == '1')
                {
                    savedStates.Push(text.ToString());
                    text.Append(string.Join("", command[2..].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray()));
                }
                else if (command[0] == '2')
                {
                    savedStates.Push(text.ToString());
                    text.Remove(text.Length - int.Parse(command.Split()[1]), int.Parse(command.Split()[1]));
                }
                else if (command[0] == '3')
                {
                    Console.WriteLine($"{text[int.Parse(command.Split()[1]) - 1]}");
                }
                else if (command[0] == '4' && 0 < savedStates.Count)
                {
                    text = new StringBuilder(savedStates.Pop());
                }
            }
        }
    }
}