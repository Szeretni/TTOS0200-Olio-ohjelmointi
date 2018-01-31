using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment_04
{
    abstract class InfoClass
    {
        public abstract string Name { get; set; } //Nightwish, Apple
        public abstract string Type { get; set; } //CD, Laptop
        public abstract int ReleaseYear { get; set; }
    }
}