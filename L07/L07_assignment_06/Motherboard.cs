using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_06
{
    class Motherboard
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }

        ~Motherboard()
        {
            Console.WriteLine("Motherboard recycled.");
        }
    }
}
