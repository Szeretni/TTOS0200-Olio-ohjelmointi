using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_ex_shapes
{
    abstract class ShapeClass
    {
        public string Name { get; set; }

        public ShapeClass()
        {
        }

        public ShapeClass(string name)
        {
            Name = name;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
        }

        public abstract void Draw();
    }
}
