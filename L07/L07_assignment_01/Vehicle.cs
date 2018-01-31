using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_01
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int TyreCount { get; set; }
        public string TyreChoice { get; set; }
        public List<Tyre> tyres = new List<Tyre>();
        public Vehicle(string name, string model, int tyreCount, string tyreChoice)
        {
            Name = name;
            Model = model;
            TyreCount = tyreCount;
            TyreChoice = tyreChoice;
            Console.WriteLine("Created a new vehicle {0} model {1}", Name, Model);
            for (int i = 0; i < TyreCount;i++)
            {
                tyres.Add(new Tyre());
            }
        }
    }
}