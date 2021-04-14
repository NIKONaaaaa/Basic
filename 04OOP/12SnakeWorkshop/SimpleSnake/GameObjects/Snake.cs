namespace SimpleSnake.GameObjects
{
    using Foods;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Snake
    {
        private const char SnakeSymbol = '\u25CF';
        private const char EmptySpaceSymbol = ' ';
        private const int SnakeStartingLength = 6;

        private readonly Queue<Point> snakeElements;
        private readonly Wall wall;
        private readonly Food[] foods;

        private int foodIndex;
        private int nextLeftX;
        private int nextTopY;
        private bool isFoodSpawned;
        private int snakePoints;
        private int levelCounter;

        private int RandomFoodNumber => new Random().Next(0, this.foods.Length);
        public int SnakePoints => this.snakePoints;
        public int SnakeLevel => this.levelCounter / 10;

        public Snake(Wall wall)
        {
            this.snakeElements = new Queue<Point>();
            this.wall = wall;
            this.foods = new Food[3];
            this.foodIndex = RandomFoodNumber;
            this.GetFoods();
            this.CreateSnake();
            isFoodSpawned = false;
            this.snakePoints = 0;
            this.levelCounter = 10;
        }

        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = this.snakeElements.Last();
            GetNextPoint(direction, currentSnakeHead);

            bool isPointOfSnake =
                this.snakeElements.Any(point => point.LeftX == this.nextLeftX && point.TopY == this.nextTopY);

            if (isPointOfSnake)
            {
                return false;
            }

            Point newSnakeHead = new Point(this.nextLeftX, this.nextTopY);
            if (this.wall.IsPointOfWall(newSnakeHead))
            {
                return false;
            }

            this.snakeElements.Enqueue(newSnakeHead);
            newSnakeHead.Draw(SnakeSymbol);

            if (!this.isFoodSpawned)
            {
                this.foods[this.foodIndex].SetRandomPosition(this.snakeElements);
                this.isFoodSpawned = true;
            }

            if (this.foods[this.foodIndex].IsFoodPoint(newSnakeHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();
            snakeTail.Draw(EmptySpaceSymbol);

            return true;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = this.foods[foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                GetNextPoint(direction, currentSnakeHead);
            }

            this.snakePoints += length;
            this.foodIndex = RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
            this.levelCounter++;
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = direction.LeftX + snakeHead.LeftX;
            this.nextTopY = direction.TopY + snakeHead.TopY;
        }

        private void CreateSnake()
        {
            for (int topY = 1; topY <= SnakeStartingLength; topY++)
            {
                this.snakeElements.Enqueue(new Point(2, topY));
            }
        }

        private void GetFoods()
        {
            this.foods[0] = new FoodHash(this.wall);
            this.foods[1] = new FoodDollar(this.wall);
            this.foods[2] = new FoodAsterisk(this.wall);
        }

        //   TODO: Implement Reflection
        //private void GetFoods()
        //{
        //    Assembly assembly = Assembly.GetExecutingAssembly();
        //    Type[] foodTypes = assembly.GetTypes().Where(type => type.Name.StartsWith("Food")).ToArray();
        //}
    }
}