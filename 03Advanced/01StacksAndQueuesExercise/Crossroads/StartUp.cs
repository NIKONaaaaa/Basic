namespace Crossroads
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            int greenLightDuration = int.Parse(Console.ReadLine()), freeWindowDuration = int.Parse(Console.ReadLine()), carsPassed = 0;
            bool crashed = false;
            char collisionLocation = ' ';
            Queue<string> waitingCars = new Queue<string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command != "green")
                {
                    waitingCars.Enqueue(command);
                }
                else
                {
                    int greenTimeLeft = greenLightDuration;
                    while (0 < waitingCars.Count && 0 < greenTimeLeft)
                    {
                        string car = waitingCars.Peek();
                        if (greenTimeLeft + freeWindowDuration < car.Length)
                        {
                            crashed = true;
                            collisionLocation = car[greenTimeLeft + freeWindowDuration];
                            break;
                        }
                        waitingCars.Dequeue();
                        carsPassed++;
                        greenTimeLeft -= car.Length;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(crashed
                ? $"A crash happened!\n{waitingCars.Peek()} was hit at {collisionLocation}."
                : $"Everyone is safe.\n{carsPassed} total cars passed the crossroads.");
        }
    }
}