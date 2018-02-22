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
            Area(radius, 0);
            Circumference(radius, 0);
        }
        
        //methods
        public override void Area(double radius,double placeholder)
        {
            area = Math.PI * (Math.Pow(radius, 2));
        }

        public override void Circumference(double radius, double placeholder)
        {
            circumference = 2 * Math.PI * radius;
        }

        //properties
        private double radius;
        public override string Name { get; set; }

        //field values
        public double area;
        public double circumference;
    }
}
