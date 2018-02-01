using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_02
{
    class Edibles
    {
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Weight { get; set; }

        public Edibles(string name)
        {
            Name = name;
            Console.WriteLine("Edible created: " + name);
        }
        
        //etc
    }
}
