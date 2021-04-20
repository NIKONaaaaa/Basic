namespace FruitOrVegetable
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string plantName = Console.ReadLine().ToLower();
            string plantType = "";
            switch (plantName)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    plantType = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    plantType = "vegetable";
                    break;
                default:
                    plantType = "unknown";
                    break;
            }
            Console.WriteLine($"{plantType}");
        }
    }
}