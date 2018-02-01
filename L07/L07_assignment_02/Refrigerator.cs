using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_02
{
    class Refrigerator
    {
        public string RefrigeratorType { get; set; }
        //constructor
        public Refrigerator(string type, string partsType)
        {
            RefrigeratorType = type;
            Console.WriteLine("Refrigerator created. Type: " + RefrigeratorType);
            Parts part1 = new Parts(partsType);
        }

        public void PrintEdible(string edibleName)
        {
            Console.WriteLine("Refrigerator has: " + edibleName);
        }
    }
}
