using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            while(true)
            {
                amplifier.AmplifierVolme();
            }
        }
    }
}
