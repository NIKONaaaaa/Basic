﻿namespace SimpleSnake.GameObjects
{
    using System;
    public class Point
    {
        public int LeftX { get; set; }
        public int TopY { get; set; }

        public Point(int leftX, int topY)
        {
            this.LeftX = leftX;
            this.TopY = topY;
        }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, this.TopY);
            Console.Write(symbol);
        }

        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX, topY);
            Console.Write(symbol);
        }

    }
}