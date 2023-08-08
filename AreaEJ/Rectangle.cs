using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaEJ
{
    internal class Rectangle
    {


        private double length; // Attribute to store the length of the rectangle
        private double width;  // Attribute to store the width of the rectangle

        // Default constructor
        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        // Constructor with parameters to initialize the length and width of the rectangle
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Accessors to get or set the values of length and width
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return length * width;
        }
    }

    

}

