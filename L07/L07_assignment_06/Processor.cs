using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_06
{
    class Processor
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int MegaHertz { get; set; }

        ~Processor()
        {
            Console.WriteLine("Processor recycled.");
        }
    }
}
