using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_04
{
    class Circle : Shape
    {
        //constructors
        public Circle(double radius,double placeholder)
        {
            Name = "Circle";
            this.radius = radius;
        }
        
        //methods
        public override double Area(double radius,double placeholder)
        {
            area = Math.PI * (Math.Pow(radius, 2));
            return area;
        }

        public override double Circumference(double radius, double placeholder)
        {
            circumference = 2 * Math.PI * radius;
            return circumference;
        }

        //properties
        public override string Name { get; set; }

        //field values
        private double radius;
        private double area;
        private double circumference;
    }
}
