using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_04
{
    class L12_04_Main
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
            shape.shapeList.Add(shape);
        }
    }
}
