using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment_04
{
    class MediaClass : InfoClass
    {
        public string Genre { get; set; } //classical, drama
        public string Author { get; set; } //artistName, writer
        public override int ReleaseYear { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
    }
}