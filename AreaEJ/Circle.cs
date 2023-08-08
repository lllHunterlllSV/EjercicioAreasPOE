using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaEJ
{
    internal class Circle
    {

        private double radius; // Attribute to store the radius of the circle

        // Default constructor
        public Circle()
        {
            radius = 0;
        }

        // Constructor with parameter to initialize the radius of the circle
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Accessor to get or set the value of the radius
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Method to calculate the area of the circle
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

   

}

