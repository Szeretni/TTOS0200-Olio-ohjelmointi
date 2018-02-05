using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_06
{
    class RAM
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Memory { get; set; }

        ~RAM()
        {
            Console.WriteLine("RAM recycled.");
        }
    }
}
