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
            CreateShape("Circle", 1);
        }

        static void CreateShape(string s,double d)
        {
            switch (s)
            {
                case "Circle":
                    Shape sh = new Circle(d);
                    double area = sh.Area(d);
                    double circumference = sh.Circumference(d);
                    Console.WriteLine("Circle Radius={0} Area={1} Circumference={2}", d, area, circumference);
                    break;
                case "Rectangle":
                    sh = new Rectangle();
                    area = sh.Area(d);
                    circumference = sh.Circumference(d);
                    Console.WriteLine("Circle Radius={0} Area={1} Circumference={2}", d, area, circumference);
                    break;
                default:
                    Console.WriteLine("Unkown shape.");
                    break;
            }
        }
    }
}
