using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_02
{
    class L07_02_Main
    {
        static void Main(string[] args)
        {
            Refrigerator refrig = new Refrigerator("Box","Door");
            Edibles carrot = new Edibles("Carrot");

            refrig.PrintEdible(carrot.Name);
        }
    }
}
