namespace SimpleSnake.GameObjects.Foods
{
    using System;
    public class FoodDollar : Food
    {
        private const char FoodSymbol = '$';
        private const int Points = 2;
        private const ConsoleColor Color = ConsoleColor.Blue;
        public FoodDollar(Wall wall) : base(wall, FoodSymbol, Points, Color)
        {

        }
    }
}