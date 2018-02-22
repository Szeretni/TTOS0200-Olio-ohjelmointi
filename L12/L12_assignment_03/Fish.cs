using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_03
{
    class Fish
    {
        //constructor
        private Fish(string Specie, double Lenght, double Weight)
        {
            this.Specie = Specie;
            this.Lenght = Lenght;
            this.Weight = Weight;
        }

        //methods
        static public Fish CreateFish(string Specie, double Lenght, double Weight, Collections Registry)
        {
            Fish fish = new Fish(Specie, Lenght, Weight);
            Registry.Fishlist.Add(fish);
            return fish;
        }

        public void PrintFish()
        {
            Console.WriteLine(" - {0} {1} cm {2} kg", Specie,Lenght,Weight);
        }

        //properties
        public string Specie { get; }
        public double Lenght { get; }
        public double Weight { get; }

    }
}
