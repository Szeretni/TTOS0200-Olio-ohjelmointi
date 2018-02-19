using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_03
{
    class Fisher
    {
        //constructors
        private Fisher(string Name, string PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            Console.WriteLine("\nA new fisherman added to Fish-register");
            Console.WriteLine("- Fisherman: {0} Phone: {1}", Name, PhoneNumber);
        }

        //methods
        //create fisher
        static public void CreateFisher(string Name, string PhoneNumber, Collections Registry)
        {
            //checks if already exists
            var match = Registry.Fisherlist.Any(x => x.Name == Name && x.PhoneNumber == PhoneNumber);
            if (match)
            {
                Console.WriteLine("Fisher already exists. Creation failed.");
            }
            if (!match)
            {
                Registry.Fisherlist.Add(new Fisher(Name,PhoneNumber));
            }
        }

        //print fisher
        public void PrintFisher()
        {
            Console.WriteLine("- Fisherman: {0} Phone: {1}", Name, PhoneNumber);
        }

        //properties
        public string Name { get; }
        private string PhoneNumber { get; set; }
    }
}
