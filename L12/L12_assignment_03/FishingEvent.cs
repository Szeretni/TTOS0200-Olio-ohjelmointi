using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_03
{
    class FishingEvent
    {
        //constructors
        private FishingEvent(Fisher fisher, Fish fish, Location location)
        {
            this.fisher = fisher;
            this.fish = fish;
            this.location = location;
            Console.WriteLine("\nFisher : {0} got a new fish", fisher.Name);
            Console.WriteLine(" - specie : {0} {1} cm {2} kg", fish.Specie, fish.Lenght, fish.Weight);
            Console.WriteLine(" - place : {0}", location.Place);
            Console.WriteLine(" - location : {0}", location.LocationS);
        }

        //methods
        static public void CreateFishingEvent(Fisher fisher, Fish fish, Location location,Collections Registry)
        {
            //id creation
            Name = name + ind.ToString();
            ind++;

            //object creation
            Registry.FishingEventDict.Add(Name, new FishingEvent(fisher, fish, location));
        }

        public void PrintFishingEventInfo()
        {
            fish.PrintFish();
            location.PrintLocation();
            fisher.PrintFisher();
        }

        //properties
        public Fisher fisher;
        public Fish fish;
        public Location location;
        static private long ind = 0;
        static private string name = "FishingEvent_";
        static private string Name { get; set; }
    }
}
