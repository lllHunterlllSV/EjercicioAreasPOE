using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaEJ
{
    internal class Square
    {

        private double side; // Attribute to store the side of the square

        // Default constructor
        public Square()
        {
            side = 0;
        }

        // Constructor with parameter to initialize the side of the square
        public Square(double side)
        {
            this.side = side;
        }

        // Accessor to get or set the value of the side
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        // Method to calculate the area of the square
        public double CalculateArea()
        {
            return side * side;
        }
    }
}

    



