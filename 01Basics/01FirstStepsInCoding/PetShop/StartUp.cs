namespace PetShop
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherCount = int.Parse(Console.ReadLine());
            double dogFood = 2.5;
            double otherCost = 4;
            double totalCost = dogCount * dogFood + otherCount * otherCost;
            Console.WriteLine($"{totalCost} lv.");
        }
    }
}