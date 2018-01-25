using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // a lot of different animals in a list
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            //animals.Add(new Rooster());
            animals.Add(new Chicken());
            animals.Add(new Dog());
            animals.Add(new Cat());
            //animals.Add(new Rooster());
            animals.Add(new Chicken());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            //animals.Add(new Rooster());
            // virtual method talk is invoked on each of the derived classes, not the base class. 
            foreach (Animal animal in animals)
            {
                // note we can handle this with one talk-method!
                animal.Talk();

                /*//doesnt work
                if (animal is Dog)
                {
                    Console.WriteLine("This one is a chicken");
                    Chicken chicken = animal as Chicken;
                    chicken.Talk();
                }
                */

                if (animal is Chicken)
                {
                    Console.WriteLine("This one is a chicken");
                    Chicken chicken = animal as Chicken;
                    //chicken.Talk();
                }

                //Console.WriteLine("Animal is: " + animal.GetType());
            }
        }
    }
}
