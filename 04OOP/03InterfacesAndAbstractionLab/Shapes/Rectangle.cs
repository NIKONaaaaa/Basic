namespace Shapes
{
    using System;
    public class Rectangle : IDrawable
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height
        {
            get => height;
            private set => height = value;
        }

        public int Width
        {
            get => width;
            private set => width = value;
        }

        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i < this.height - 1; ++i)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}