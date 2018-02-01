using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_01
{
    class Vehicle
    {
        private string Name { get; set; }
        private string Model { get; set; }
        private int TyreCount { get; set; }
        private string TyreChoice { get; set; }
        private List<Tyre> tyres = new List<Tyre>();
        public Vehicle(string name, string model, int tyreCount, string tyreChoice)
        {
            Name = name;
            Model = model;
            TyreCount = tyreCount;
            TyreChoice = tyreChoice;
            Console.WriteLine("Created a new vehicle {0} model {1}", Name, Model);
            for (int i = 0; i < TyreCount;i++)
            {
                tyres.Add(new Tyre(TyreChoice, Name,Model));
            }
            Console.WriteLine();
        }
        public void VehicleInfo()
        {
            Console.WriteLine("Vehicle Name: {0} Model:{1}", Name, Model);
            Console.WriteLine("Tyres:");
            foreach (Tyre t in tyres)
            {
                Console.WriteLine("-Name: {0} Model:{1} TyreSize:{2}", t.Trademark,t.Type,t.TyreSize );
            }
            Console.WriteLine();
        }
    }
}