using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment05
{
    class L06_05_Main
    {
        static void Main(string[] args)
        {
            BaseCharacter borderLine = new BaseCharacter();
            borderLine.ObjectOwner = "System";
            Console.WriteLine(borderLine.ObjectOwner);

            PlayerCharacter pc = new PlayerCharacter();
            pc.ObjectOwner = "Player";
        }
    }
}