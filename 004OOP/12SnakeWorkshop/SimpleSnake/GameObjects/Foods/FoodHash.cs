namespace SimpleSnake.GameObjects.Foods
{
    using System;
    public class FoodHash : Food
    {
        private const char FoodSymbol = '#';
        private const int Points = 3;
        private const ConsoleColor Color = ConsoleColor.Green;
        public FoodHash(Wall wall) : base(wall, FoodSymbol, Points, Color)
        {

        }
    }
}