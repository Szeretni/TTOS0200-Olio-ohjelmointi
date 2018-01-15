using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        private static int MaxSpeed = 200;
        //properties
        public string Model { get; set; }
        public string Color { get; set;}
        public double EngineSize { get; set; }
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }

        public void Accelerate()
        {
            Speed += 5;
        }

        public void Brake()
        {
            Speed -= 5;
        }

        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + EngineSize);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
        }

        //constuctor
        public Car(string model, string color, double engineSize, bool fuzzyDices, int doorCount)
        {
            Model = model;
            Color = color;
            EngineSize = engineSize;
            FuzzyDices = fuzzyDices;
            DoorCount = doorCount;
            Speed = 0;
        }

        //destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed");
        }
    }
}
