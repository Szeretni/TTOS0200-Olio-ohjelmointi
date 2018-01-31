using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment05
{
    class Terrain : GameEngine
    {
        public override string ObjectOwner { get; set; }
        public override int[,] ObjectPosition { get; set; }
        public override int ObjectController { get; set; }
        public string TerrainType { get; set; }
    }
}
