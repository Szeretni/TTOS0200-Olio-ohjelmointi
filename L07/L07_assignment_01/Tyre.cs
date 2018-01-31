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
        public Tyre(string trademark, string type, string tyreSize)
        {
            Trademark = trademark;
            Type = type;
            TyreSize = tyreSize;
        }
    }
}
