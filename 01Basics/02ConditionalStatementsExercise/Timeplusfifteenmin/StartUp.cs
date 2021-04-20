namespace TimePlusFifteenMin
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 15;
            if (minute >= 60)
            {
                minute -= 60;
                hour += 1;
            }
            if (hour > 23)
            {
                    hour = 0;
            }
            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}