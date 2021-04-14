namespace DataTypes
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                PerformAction(int.Parse(Console.ReadLine()));
            }
            else if (dataType == "real")
            {
                PerformAction(double.Parse(Console.ReadLine()));
            }
            else
            {
                PerformAction(Console.ReadLine());
            }
        }
        static void PerformAction(int number)
        {
            Console.WriteLine(number * 2);
        }
        static void PerformAction(double number)
        {
            Console.WriteLine($"{number * 1.5:f2}");
        }
        static void PerformAction(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}