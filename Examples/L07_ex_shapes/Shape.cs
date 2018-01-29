using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_ex_shapes
{
    class Shape
    {
        static void Main(string[] args)
        {
            //
            //ShapeClass shape = new ShapeClass();
            ShapeClass circle = new CircleClass();
            circle.Draw();

            List<ShapeClass> drawingObjects = new List<ShapeClass>();
            // use polymorphis to store objects
            drawingObjects.Add(new CircleClass());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new CircleClass());
            drawingObjects.Add(new Square());

            Console.WriteLine("Loop through all drawing objects in a list:");
            foreach (ShapeClass drawingObject in drawingObjects)
            {
                drawingObject.Draw(); // "Draw Circle!" "Draw Square!" ...
            }
        }
    }
}
