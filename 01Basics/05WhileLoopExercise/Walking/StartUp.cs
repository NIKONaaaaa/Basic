namespace Walking
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int stepCount = 0;
            while (stepCount < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    stepCount += int.Parse(Console.ReadLine());
                    break;
                }
                stepCount += int.Parse(input);
            }
            if (10000 <= stepCount)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepCount - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepCount} more steps to reach goal.");
            }
        }
    }
}