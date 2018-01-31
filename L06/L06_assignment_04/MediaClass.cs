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
        //Visual Studio adds {get;set;} automatically
        public override int ReleaseYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}