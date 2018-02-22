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
            CreateShape("Circle", 1, 0);
            CreateShape("Circle", 2, 0);
            CreateShape("Circle", 3, 0);
            CreateShape("Rectangle", 10, 20);
            CreateShape("Rectangle", 20, 30);
            CreateShape("Rectangle", 40, 50);
        }

        static void CreateShape(string s,double d, double e)
        {
            switch (s)
            {
                case "Circle":
                    Shape sh = new Circle(d,e); 
                    Console.WriteLine("Circle Radius={0} Area={1:.00} Circumference={2:.00}", d, e, e);
                    break;
                case "Rectangle":
                    sh = new Rectangle(d,e);
                    Console.WriteLine("Rectangle Widht={0} Height={1} Area={2:.00} Circumference={3:.00}", d, e, e, e);
                    break;
                default:
                    Console.WriteLine("Unkown shape.");
                    break;
            }
        }
    }
}
