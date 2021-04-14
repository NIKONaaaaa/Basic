namespace Vacation
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string[] groupList = { "Students", "Business", "Regular" }, dayList = { "Friday", "Saturday", "Sunday" };
            double[,] priceList = { { 8.45, 9.8, 10.46 }, { 10.9, 15.6, 16 }, { 15, 20, 22.5 } };
            int groupNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine(), day = Console.ReadLine();
            int groupIndex = Array.IndexOf(groupList, groupType), dayIndex = Array.IndexOf(dayList, day);
            double discount = 1.0;
            if (groupIndex == 0 && 30 <= groupNumber)
            {
                discount -= 0.15;
            }
            else if (groupIndex == 1 && 100 <= groupNumber)
            {
                groupNumber -= 10;
            }
            else if (groupIndex == 2 && (10 <= groupNumber && groupNumber <= 20))
            {
                discount -= 0.05;
            }
            Console.WriteLine($"Total price: {discount * groupNumber * priceList[groupIndex, dayIndex]:f2}");
        }
    }
}