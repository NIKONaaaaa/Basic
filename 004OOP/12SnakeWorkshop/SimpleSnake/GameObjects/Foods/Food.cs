namespace SimpleSnake.GameObjects.Foods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Food : Point
    {
        private readonly char foodSymbol;
        private readonly Random random;
        private readonly Wall wallInfo;
        private ConsoleColor foodColor;

        protected Food(Wall wall, char foodSymbol, int foodPoints, ConsoleColor foodColor) : base(wall.LeftX, wall.TopY)
        {
            this.random = new Random();
            this.wallInfo = wall;
            this.foodSymbol = foodSymbol;
            this.FoodPoints = foodPoints;
            this.foodColor = foodColor;
        }
        public int FoodPoints { get; private set; }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            bool isPointOfSnake = false;
            do
            {
                this.LeftX = random.Next(2, wallInfo.LeftX - 2);
                this.TopY = random.Next(2, wallInfo.TopY - 2);

                isPointOfSnake = snakeElements.Any(p => p.LeftX == this.LeftX && p.TopY == this.TopY);
            } while (isPointOfSnake);

            Console.BackgroundColor = this.foodColor;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }

        public bool IsFoodPoint(Point snakeHead)
        {
            return this.LeftX == snakeHead.LeftX && this.TopY == snakeHead.TopY;
        }
    }
}