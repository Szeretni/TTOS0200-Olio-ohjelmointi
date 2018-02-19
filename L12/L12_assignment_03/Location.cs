using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_03
{
    class Location
    {
        //constructors
        private Location(string Place,string Location)
        {
            this.Place = Place;
            LocationS = Location;
        }

        //methods
        //create location
        static public void CreateLocation(string Place, string Location, Collections Registry)
        {
            //checks if already exists
            var match = Registry.Locationlist.Any(x => x.Place == Place && x.LocationS == Location);
            if (match)
            {
                Console.WriteLine("Location already exists. Creation failed.");
            }
            if (!match)
            {
                Registry.Locationlist.Add(new Location(Place, Location));
            }
        }

        //properties
        public string Place { get; }
        public string LocationS { get; }
    }
}
