namespace SimpleSnake.Core
{
    using System;
    using Enums;
    using GameObjects;
    using Contracts;
    using System.Threading;
    using System.IO;
    using System.Text;
    public class Engine : IEngine
    {
        private readonly Point[] pointsOfDirection;
        private Direction direction;
        private readonly Snake snake;
        private readonly Wall wallInfo;
        private double sleepTime;
        private readonly double version;

        public Engine(Wall wall, Snake snake)
        {
            this.wallInfo = wall;
            this.snake = snake;
            this.sleepTime = 100;
            this.pointsOfDirection = new Point[4];
            this.version = 1.00;
        }
        public void Run()
        {
            this.CreateDirections();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    this.GetNextDirection();
                }
                bool isMoving = this.snake.IsMoving(this.pointsOfDirection[(int)this.direction]);

                if (!isMoving)
                {
                    this.AskUserForRestart();
                }

                this.PrintStatisticsInfo();

                sleepTime -= 0.01;

                Thread.Sleep((int)sleepTime);
            }
        }

        private void CreateDirections()
        {
            this.pointsOfDirection[0] = new Point(1, 0);
            this.pointsOfDirection[1] = new Point(-1, 0);
            this.pointsOfDirection[2] = new Point(0, 1);
            this.pointsOfDirection[3] = new Point(0, -1);
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            switch (userInput.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (this.direction != Direction.Right)
                    {
                        this.direction = Direction.Left;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (this.direction != Direction.Left)
                    {
                        this.direction = Direction.Right;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (this.direction != Direction.Up)
                    {
                        this.direction = Direction.Down;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (this.direction != Direction.Down)
                    {
                        this.direction = Direction.Up;
                    }
                    break;
            }
            Console.CursorVisible = false;
        }

        private void AskUserForRestart()
        {
            int leftX = this.wallInfo.LeftX + 2;
            int topY = 6;

            Console.SetCursorPosition(leftX, topY);
            Console.Write("Would you like to continue? y/n");
            Console.SetCursorPosition(leftX, topY + 1);
            Console.Write("Your choice: ");

            string input = Console.ReadKey().KeyChar.ToString();
            if (input == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else if (input == "n")
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(23, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Game over!\n");
            Console.SetCursorPosition(13, 11);
            Console.ForegroundColor = ConsoleColor.Black;
            StringBuilder sb = new StringBuilder();
            Environment.Exit(0);
        }

        private void PrintStatisticsInfo()
        {
            int leftX = this.wallInfo.LeftX + 2;
            int topY = 2;
            Console.SetCursorPosition(leftX, topY - 1);
            Console.Write(new string('-', 18));
            Console.SetCursorPosition(leftX, topY);
            Console.Write($"Player points: {this.snake.SnakePoints * 5}");
            Console.SetCursorPosition(leftX, topY + 1);
            Console.Write($"Player level : {this.snake.SnakeLevel}");
            Console.SetCursorPosition(leftX, topY + 2);
            Console.Write(new string('-', 18));
            Console.SetCursorPosition(leftX, topY + 4);
            Console.SetCursorPosition(leftX, topY + 17);
            Console.Write($"Version: {this.version:f2}");

            // TODO: Implement High Score
        }
    }
}