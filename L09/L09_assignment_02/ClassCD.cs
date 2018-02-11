using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment07
{
    class ClassCD
    {
        //creates unlimited songlist
        public List<ClassSongs> SongList  = new List<ClassSongs>();
        //public ClassSongs[] SongList = new ClassSongs[Int16.MaxValue];
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
    }
}
