using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment03
{
    class L06_03_Main
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            int input = -1;
            while (input != 0)
            {
                Console.WriteLine("0) Exit\n1) Print info\n2) Set Power\n3) Set Volume\n4) Set Frequency");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        radio.PrintInfo();
                        break;
                    case 2:
                        radio.PowerSet();
                        break;
                    case 3:
                        radio.VolumeSet();
                        break;
                    case 4:
                        radio.FrequencySet();
                        break;
                }
            }
        }
    }
}
