namespace ProjectsCreation
{
using System;
    class StartUp
    {
        static void Main()
        {
            string architectName = Console.ReadLine();
            int projectNumber = int.Parse(Console.ReadLine());
            int timePerProject = 3;
            Console.WriteLine($"The architect {architectName} will need {projectNumber * timePerProject} hours to complete {projectNumber} project/s.");
        }
    }
}