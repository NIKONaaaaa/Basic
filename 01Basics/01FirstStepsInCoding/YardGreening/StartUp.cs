namespace YardGreening
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double totalSquareMeters = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double discountPercentage = 0.18;
            double totalPrice = totalSquareMeters * pricePerSquareMeter;
            double totalDiscount = totalPrice * discountPercentage;
            double priceAfterDiscount = totalPrice - totalDiscount;
            Console.WriteLine($"The final price is {priceAfterDiscount} lv.");
            Console.WriteLine($"The discount is {totalDiscount} lv.");
        }
    }
}