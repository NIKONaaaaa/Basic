namespace GameOfIntervals
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int countMove = int.Parse(Console.ReadLine());
            double count09 = 0;
            double count1019 = 0;
            double count2029 = 0;
            double count3039 = 0;
            double count4050 = 0;
            double countInvalid = 0;
            double result = 0;
            for (int i = 1; i <= countMove; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (0 <= number && number < 30)
                {
                    if (20 <= number)
                    {
                        count2029++;
                        result += number * 0.4;
                    }
                    else if (10 <= number)
                    {
                        count1019++;
                        result += number * 0.3;
                    }
                    else
                    {
                        count09++;
                        result += number * 0.2;
                    }
                }
                else if (30 <= number && number <= 50)
                {
                    if (40 <= number)
                    {
                        count4050++;
                        result += 100;
                    }
                    else
                    {
                        count3039++;
                        result += 50;
                    }
                }
                else
                {
                    countInvalid++;
                    result /= 2;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(count09 / countMove) * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(count1019 / countMove) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(count2029 / countMove) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(count3039 / countMove) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(count4050 / countMove) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(countInvalid / countMove) * 100:f2}%");
        }
    }
}