using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaEJ
{
    internal class Triangle
    {
       
        private double baseLength; // Attribute to store the base length of the triangle
        private double height;     // Attribute to store the height of the triangle

        // Default constructor
        public Triangle()
        {
            baseLength = 0;
            height = 0;
        }

        // Constructor with parameters to initialize the base length and height of the triangle
        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        // Accessors to get or set the values of base length and height
        public double BaseLength
        {
            get { return baseLength; }
            set { baseLength = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Method to calculate the area of the triangle
        public double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
    }

}

