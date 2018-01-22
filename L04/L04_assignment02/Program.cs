using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi elevator = new Hissi();
            while(true)
            {
                elevator.ElevatorMove();
            }
        }
    }
}
