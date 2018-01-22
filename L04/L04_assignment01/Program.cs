using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank TestTank = new Tank();
            TestTank.AccelerateTo(199);
            TestTank.SlowTo(-1);
        }
    }
}
