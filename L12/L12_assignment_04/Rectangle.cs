using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_04
{
    class Rectangle : Shape
    {
        //constructors
        public Rectangle(double height,double width)
        {
            Name = "Rectangle";
            this.height = height;
            this.width = width;
        }
        public override string Name { get; set; }

        public override double Area(double width, double height)
        {
            double result = width * height;
            return result;
        }

        public override double Area(double placeholder) //not needed, have to give width and height, even though they can be equal
        {
            double result = placeholder * placeholder;
            return result;
        }

        public override double Circumference(double placeholder) //not needed, have to give width and height, even though they can be equal
        {
            double result = 4 * placeholder;
            return result;
        }

        public override double Circumference(double width, double height)
        {
            double result = 2 * width + 2 * height;
            return result;
        }

        //properties
        private double height;
        private double width;
    }
}
