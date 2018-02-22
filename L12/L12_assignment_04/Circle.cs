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
        public Circle(double radius)
        {
            Name = "Circle";
            this.radius = radius;
        }
        
        //methods
        public override double Area(double radius)
        {
            double result = Math.PI * (Math.Pow(radius, 2));
            return result;
        }

        public override double Area(double placeholder1, double placeholder2)
        {
            double result = Math.PI * (Math.Pow(placeholder1, 2));
            return result;
        }

        public override double Circumference(double radius)
        {
            double result = 2 * Math.PI * radius;
            return result;
        }

        public override double Circumference(double placeholder1, double placeholder2)
        {
            double result = 2 * Math.PI * placeholder1;
            return result;
        }

        //properties
        private double radius;
        public override string Name { get; set; }
    }
}
