namespace BackInThirtyMinutes
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sum = hours * 60 + minutes + 30;
            double newHours = Math.Floor(1.0 * sum / 60);
            int newMinutes = sum % 60;
            if (23 < newHours)
            {
                newHours -= 24;
            }
            Console.WriteLine($"{newHours}:{newMinutes:d2}");
        }
    }
}