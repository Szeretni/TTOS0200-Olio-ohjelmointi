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
            area = width * height;
            return area;
        }

        public override double Circumference(double width, double height)
        {
            circumference = 2 * width + 2 * height;
            return circumference;
        }

        //field values
        private double height;
        private double width;
        private double area;
        private double circumference;
    }
}
