using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__1
{
    public class Box
    {
        private double Length { get; set; }
        private double Width { get; set; }
        private double Height { get; set; }

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;

            if (length <= 0 )
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

            double surfaceArea= 2*(length * width + length * height + width * height);
            double lateralSurfaceArea = 2 * (length * height + width * height);
            double volume = length * width * height;

            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}
