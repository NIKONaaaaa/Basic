namespace Logistics
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int loadCount = int.Parse(Console.ReadLine());
            double vanTonnage = 0;
            double lorryTonnage = 0;
            double trainTonnage = 0;
            double totalTonnage = 0;
            double priceTotal = 0;
            for (int i = 1; i <= loadCount; i++)
            {
                double currentTonnage = double.Parse(Console.ReadLine());
                totalTonnage += currentTonnage;
                if (currentTonnage <= 11)
                {
                    if (4 <= currentTonnage)
                    {
                        lorryTonnage += currentTonnage;
                        priceTotal += currentTonnage * 175;
                    }
                    else
                    {
                        vanTonnage += currentTonnage;
                        priceTotal += currentTonnage * 200;
                    }
                }
                else
                {
                    trainTonnage += currentTonnage;
                    priceTotal += currentTonnage * 120;
                }
            }
            Console.WriteLine($"{(priceTotal / totalTonnage):f2}");
            Console.WriteLine($"{(vanTonnage / totalTonnage) * 100:f2}%");
            Console.WriteLine($"{(lorryTonnage / totalTonnage) * 100:f2}%");
            Console.WriteLine($"{(trainTonnage / totalTonnage) * 100:f2}%");
        }
    }
}