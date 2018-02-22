///@author Hannu Oksman
///TODO: annoyance with abstract shape: circle which doesn't need two numerical arguments, but rectangle needs.
/*
 * Circle Radius=1 Area=3,14159265358979 Circumference=6,28318530717959
 * Circle Radius=2 Area=12,5663706143592 Circumference=12,5663706143592
 * Circle Radius=3 Area=28,2743338823081 Circumference=18,8495559215388
 * Rectangle Widht=10 Height=20 Area=200 Circumference=60
 * Rectangle Widht=20 Height=30 Area=600 Circumference=100
 * Rectangle Widht=40 Height=50 Area=2000 Circumference=180
 * Press any key to continue . . .
 * */
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
                    Console.WriteLine("Circle Radius={0} Area={1:.00} Circumference={2:.00}", d, sh.Area(d, 0).ToString(), sh.Circumference(d, 0).ToString());
                    break;
                case "Rectangle":
                    sh = new Rectangle(d,e);
                    Console.WriteLine("Rectangle Widht={0} Height={1} Area={2:.00} Circumference={3:.00}", d, e, sh.Area(d,e).ToString(), sh.Circumference(d,e).ToString());
                    break;
                default:
                    Console.WriteLine("Unkown shape.");
                    break;
            }
        }
    }
}
