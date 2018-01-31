using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment05
{
    abstract class GameEngine
    {
        public abstract string ObjectOwner { get; set; }
        public abstract int[,] ObjectPosition { get; set; }
        public abstract int ObjectController { get; set; }
    }
}
