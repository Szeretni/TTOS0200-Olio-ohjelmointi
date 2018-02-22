using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_04
{
    abstract class Shape
    {
        //collections
        public List<Shape> shapeList = new List<Shape>();

        //properties
        abstract public string Name { get; set; }

        //methods
        abstract public void Area(double d, double e);
        abstract public void Circumference(double d,double e);
    }
}
