using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculate()
        {
            return side1 * side2;
        }

        private double PerimeterCalculate()
        {
            return 2 * (side1 + side2);
        }

        public double Area { get { return AreaCalculate(); } }
        public double Perimeter { get { return PerimeterCalculate(); } }
    }
}
