namespace Bills
{
    using System;
    class StartUp
    {
        const int billWater = 20;
        const int billInternet = 15;
        static void Main(string[] args)
        {
            int monthCount = int.Parse(Console.ReadLine());
            double billElectricity = 0;
            for (int i = 1; i <= monthCount; i++)
            {
                billElectricity += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Electricity: {billElectricity:f2} lv");
            Console.WriteLine($"Water: {billWater * monthCount:f2} lv");
            Console.WriteLine($"Internet: {billInternet * monthCount:f2} lv");
            Console.WriteLine($"Other: {(billElectricity + (billWater + billInternet) * monthCount) * 1.2:f2} lv");
            Console.WriteLine($"Average: {(billElectricity / monthCount + billWater + billInternet) * 2.2:f2} lv");
        }
    }
}