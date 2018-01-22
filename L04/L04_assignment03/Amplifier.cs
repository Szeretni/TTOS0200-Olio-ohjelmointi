using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_assignment03
{
    class Amplifier
    {
        public void AmplifierVolme()
        {
            Console.Write("Giva a new volume value (0-100) > ");
            int input;
            bool result = int.TryParse(Console.ReadLine(),out input);
            if (result)
            {
                Volume = input;
            }
            else
            {
                Console.WriteLine("Your input was not integer");
            }
        }
  
        private int minVolume = 0;
        private int maxVolume = 100;
        private int volume;
        private int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < minVolume)
                {
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : 0");
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("  -> Too much volume -  Amplifier volume is set to maximum : 100");
                }
                else
                {
                    volume = value;
                    Console.WriteLine("-> Amplifier volume is set to : " + Volume);
                }
            }
        }
    }
}