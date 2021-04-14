namespace DayOfWeek
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int[] herkaderka = { 1, 2, 3, 4, 5, 6, 7 };
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (Array.IndexOf(herkaderka, day) < 0)
            {
                Console.Write("Invalid day!");
            }
            else
            {
                Console.Write(days[Array.IndexOf(herkaderka, day)]);
            }
        }
    }
}