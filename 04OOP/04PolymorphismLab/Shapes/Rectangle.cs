namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get => width;
            private set => width = value;
        }
        public double Height
        {
            get => height;
            private set => height = value;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}