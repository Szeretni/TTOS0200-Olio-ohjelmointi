using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_05
{
    class L07_05_Main
    {
        static void Main(string[] args)
        {
            //human
            Human human = new Human(5);
            Console.WriteLine("Human's age: " + human.Age);
            human.AgeMethod();
            Console.WriteLine("Human's age: " + human.Age);
            human.Move();

            //adult
            Adult adult = new Adult(33);
            Console.WriteLine("Adult's age " + adult.Age);
            adult.Move();

            //baby
            Baby baby = new Baby(0);
            Console.WriteLine("Baby's age: " + baby.Age);
            baby.Move();
        }
    }
}
