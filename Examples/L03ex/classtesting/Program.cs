using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtesting
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedTest newSpeed = new SpeedTest();
            newSpeed.Speed = 100;
            Console.WriteLine(newSpeed.Speed);
        }
    }
}
