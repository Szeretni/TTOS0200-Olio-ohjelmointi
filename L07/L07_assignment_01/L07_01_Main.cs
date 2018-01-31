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
            Tyre hakkapeliitta = new Tyre("Nokia,","Hakkapeliitta","205R16");
            Vehicle porsche = new Vehicle("Porsche", "911", 4, "hakkapeliitta");
            /*
            Vehicle vehicle = new Vehicle("Audi","A5",4,"Hakkapeliitta");
            foreach (Tyre tyre in vehicle.tyres) Console.WriteLine(tyre.Trademark);
            */
        }
    }
}
