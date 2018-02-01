using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_01
{
    class Tyre
    {
        public string Trademark { get; set; }
        public string Type { get; set; }
        public string TyreSize { get; set; }
        public Tyre(string tyreBrand, string VehName, string VehModel)
        {
            if (tyreBrand == "hakkapeliitta")
            {
                Trademark = "Nokia";
                Type = "Hakkapeliitta";
                TyreSize = "205R16";
            }
            if (tyreBrand == "mic")
            {
                Trademark = "MIC";
                Type = "Pilot";
                TyreSize = "160R17";
            }
            Console.WriteLine("Tyre {0} added to vehicle {1} model {2}",Trademark,VehName,VehModel);
        }

        
        /*
        public Tyre(string trademark, string type, string tyreSize)
        {
            Trademark = trademark;
            Type = type;
            TyreSize = tyreSize;
        }
        */
    }
}
