using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_examples
{
    class CarApplication
    {
        static void Main(string[] args)
        {
            //create a new car instance
            Car datsun = new Car();
            datsun.Speed = 300;

            Console.WriteLine(datsun.speed);

            
        }
    }
}
