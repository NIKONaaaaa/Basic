namespace ReportSystem
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double sumTotal = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double averageCS = 0;
            int countCS = 0;
            double averageCC = 0;
            int countCC = 0;
            int counter = 1;
            while (0 < sumTotal && input != "End")
            {
                if (counter % 2 == 1 && input != "End")
                {
                    double inputA = double.Parse(input);
                    if (100 < inputA)
                    {
                        Console.WriteLine("Error in transaction!");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumTotal -= double.Parse(input);
                        averageCS += double.Parse(input);
                        countCS++;
                        counter++;
                    }
                }
                else if (counter % 2 == 0 && input != "End")
                {
                    double inputA = double.Parse(input);
                    if (inputA < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumTotal -= double.Parse(input);
                        averageCC += double.Parse(input);
                        countCC++;
                        counter++;
                    }
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {averageCS / countCS:f2}");
                Console.WriteLine($"Average CC: {averageCC / countCC:f2}");
            }
        }
    }
}