namespace ClassBoxData
{
    using System;
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public string SurfaceArea()
        {
            double surfaceArea = 2 * this.Length * this.Width + 2 * this.Width * this.Height + 2 * this.Length * this.Height;
            return $"Surface Area - {surfaceArea:f2}";
        }
        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }
        public string Volume()
        {
            double volume = this.Length * this.Width * this.Height;
            return $"Volume - {volume:f2}";
        }
    }
}