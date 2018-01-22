using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBed testbed = new TestBed();
            while (true)
            {
                //testbed.TestBedFloat();
                testbed.TestBedDate();
            }
        }
    }
}
