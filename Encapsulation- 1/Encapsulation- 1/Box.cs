using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__1
{
    public class Box
    {
        private double Length;
        private double Width;
        private double Height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;

            if (length <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            if (width <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else if (height <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
        }
        public double SurfaceArea(double length, double width, double height)
        {
            double surfaceArea = 2 * (length * width + length * height + width * height);
            return surfaceArea;
        }

        public double LateralSurfaceArea(double length, double width, double height)
        {
            double lateralSurfaceArea = 2 * (length * height + width * height);
            return lateralSurfaceArea;
        }

        public double Volume(double length, double width, double height)
        {
            double volume = length * width * height;
            return volume;
        }
    }
}
