using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_01
{
    class L07_01_Main
    {
        static void Main(string[] args)
        {
            Vehicle porsche = new Vehicle("Porsche", "911", 4, "hakkapeliitta");

            porsche.VehicleInfo();

            Vehicle ducati = new Vehicle("Ducati", "Diavel", 2, "mic");
            ducati.VehicleInfo();
        }
    }
}
