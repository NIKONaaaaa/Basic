namespace NewHouse
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerAmount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double rosePrice = 5;
            double dahliaPrice = 3.8;
            double tulipPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.5;
            double totalPrice = 0;
            switch (flowerType)
            {
                case "Roses":
                    if (flowerAmount > 80)
                    {
                        totalPrice = rosePrice * flowerAmount * 0.9;
                    }
                    else
                    {
                        totalPrice = rosePrice * flowerAmount;
                    }
                    break;
                case "Dahlias":
                    if (flowerAmount > 90)
                    {
                        totalPrice = dahliaPrice * flowerAmount * 0.85;
                    }
                    else
                    {
                        totalPrice = dahliaPrice * flowerAmount;
                    }
                    break;
                case "Tulips":
                    if (flowerAmount > 80)
                    {
                        totalPrice = tulipPrice * flowerAmount * 0.85;
                    }
                    else
                    {
                        totalPrice = tulipPrice * flowerAmount;
                    }
                    break;
                case "Narcissus":
                    if (flowerAmount < 120)
                    {
                        totalPrice = narcissusPrice * flowerAmount * 1.15;
                    }
                    else
                    {
                        totalPrice = narcissusPrice * flowerAmount;
                    }
                    break;
                case "Gladiolus":
                    if (flowerAmount < 80)
                    {
                        totalPrice = gladiolusPrice * flowerAmount * 1.2;
                    }
                    else
                    {
                        totalPrice = gladiolusPrice * flowerAmount;
                    }
                    break;
            }
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerAmount} {flowerType} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}