using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_ex_interface_example
{
    class Dog : Animal, IConnectionStatusListener
    {
        public override void Talk()
        {
            Console.WriteLine("Hau");
        }

        public void OnConnectionStarted()
        {
            Console.WriteLine("DOG: OnConnectionStarted");
        }
        public void OnConnectionSuccess()
        {
            Console.WriteLine("DOG: OnConnectionSuccess");
        }
        public void OnConnectionFailure()
        {
            Console.WriteLine("DOG: OnConnectionFailure");
        }
    }
}
