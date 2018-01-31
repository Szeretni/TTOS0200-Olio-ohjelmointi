using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment_04
{
    class DeviceClass : InfoClass
    {
        public string ModelId { get; set; } //IMEI-code, model name etc.
        public double weight { get; set; }
        public override int ReleaseYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}