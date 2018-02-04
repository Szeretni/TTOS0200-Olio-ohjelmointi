using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_05
{
    class Human : Mammal
    {
        //constructor
        public Human() { }
        
        public Human(int Age)
        {
            //wanted to try 'this'
            this.Age = Age;
        }
        //methods
        public override void Move()
        {
            Console.WriteLine("I'm moving.");
        }
        public void AgeMethod()
        {
            Age++;
        }
        //properties
        public override int Age { get; set; }
        private double Weight { get; set; }
        private double Height { get; set; }
        private string Name { get; set; }
    }
}
