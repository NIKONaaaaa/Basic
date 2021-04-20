namespace SummerOutfit
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine().ToLower();
            string clothes = "Shirt";
            string shoes = "Moccasins";
            switch (timeOfDay)
            {
                case "morning":
                    if (degrees <= 18)
                    {
                        clothes = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (18 < degrees && degrees < 25)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "afternoon":
                    if (degrees <= 18)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (18 < degrees && degrees < 25)
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        clothes = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
            }
            Console.WriteLine($"It's {degrees} degrees, get your {clothes} and {shoes}.");
        }
    }
}