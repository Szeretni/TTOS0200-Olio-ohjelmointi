using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_06
{
    class L07_06_Main
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.SetInfo("AMD");
            computer.PrintInfo();
            computer = null;
            GC.Collect();

            //to see destuction without debugging
            Console.ReadKey();
        }
    }
}
