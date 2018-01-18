using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instance
            Kiuas uusiKiuas = new Kiuas();

            //current temp
            uusiKiuas.currentTemperature = 50;

            //power on
            Console.WriteLine("Virta päälle? [1=on,0=off] :");
            uusiKiuas.PowerStatus = int.Parse(Console.ReadLine());
            Console.WriteLine("Heating on: " + uusiKiuas.Power(uusiKiuas.PowerStatus));

            //set desired temp
            Console.WriteLine("Set desired temperature:");
            uusiKiuas.setTemperature = int.Parse(Console.ReadLine());
            uusiKiuas.SetTemperature(uusiKiuas.currentTemperature, uusiKiuas.setTemperature, uusiKiuas.PowerStatus);



        }
    }
}
