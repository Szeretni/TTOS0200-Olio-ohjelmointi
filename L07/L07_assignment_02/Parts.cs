using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_02
{
    class Parts
    {
        public string PartType { get; set; }
        public double PartWeight { get; set; }

        public Parts(string type)
        {
            PartType = type;
            Console.WriteLine("Part created: " + PartType);
        }

        //etc
    }
}
