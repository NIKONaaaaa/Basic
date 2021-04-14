namespace SoftUniCoursePlanning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<string> courseSchedule = Console.ReadLine().Split(", ").ToList();
            string commandInput = Console.ReadLine();
            while (commandInput != "course start")
            {
                string[] commandSplit = commandInput.Split(":");
                if (commandSplit[0] == "Add")
                {
                    if (!courseSchedule.Contains(commandSplit[1]))
                    {
                        courseSchedule.Add(commandSplit[1]);
                    }
                }
                else if (commandSplit[0] == "Insert")
                {
                    if (!courseSchedule.Contains(commandSplit[1]))
                    {
                        courseSchedule.Insert(int.Parse(commandSplit[2]), commandSplit[1]);
                    }
                }
                else if (commandSplit[0] == "Remove")
                {
                    if (courseSchedule.Contains(commandSplit[1]))
                    {
                        courseSchedule.Remove(commandSplit[1]);
                    }
                    if (courseSchedule.Contains($"{commandSplit[1]}-Exercise"))
                    {
                        courseSchedule.Remove($"{commandSplit[1]}-Exercise");
                    }
                }
                else if (commandSplit[0] == "Swap")
                {
                    string lessonOne = commandSplit[1], lessonTwo = commandSplit[2];
                    int indexOne = courseSchedule.IndexOf(lessonOne), indexTwo = courseSchedule.IndexOf(lessonTwo);
                    if (courseSchedule.Contains(commandSplit[1]) && courseSchedule.Contains(commandSplit[2]))
                    {
                        courseSchedule.Insert(indexTwo + 1, lessonOne);
                        courseSchedule.RemoveAt(indexTwo);
                        courseSchedule.Insert(indexOne + 1, lessonTwo);
                        courseSchedule.RemoveAt(indexOne);
                        if (courseSchedule.Contains($"{lessonOne}-Exercise"))
                        {
                            string exerciseName = lessonOne + "-Exercise";
                            courseSchedule.Remove(exerciseName);
                            courseSchedule.Insert(indexTwo + 1, exerciseName);
                        }
                        if (courseSchedule.Contains($"{lessonTwo}-Exercise"))
                        {
                            string exerciseName = lessonTwo + "-Exercise";
                            courseSchedule.Remove(exerciseName);
                            courseSchedule.Insert(indexOne + 1, exerciseName);
                        }
                    }
                }
                else if (commandSplit[0] == "Exercise")
                {
                    if (courseSchedule.Contains(commandSplit[1]) && !courseSchedule.Contains($"{commandSplit[1]}-Exercise"))
                    {
                        string exerciseName = commandSplit[1] + "-Exercise";
                        int index = courseSchedule.IndexOf(commandSplit[1]);
                        courseSchedule.Insert(index + 1, exerciseName);
                    }
                    else if (!courseSchedule.Contains(commandSplit[1]))
                    {
                        string exerciseName = commandSplit[1] + "-Exercise";
                        courseSchedule.Add(commandSplit[1]);
                        courseSchedule.Add(exerciseName);
                    }
                }
                commandInput = Console.ReadLine();
            }
            foreach (string element in courseSchedule)
            {
                Console.WriteLine($"{courseSchedule.IndexOf(element) + 1}.{element}");
            }
        }
    }
}