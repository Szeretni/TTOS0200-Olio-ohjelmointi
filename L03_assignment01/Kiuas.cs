using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment01
{
    class Kiuas
    {
        public string containerMaterial = "Steel";
        public string stoneMaterial = "RandomStone";
        public string heatingSystem = "woodComsumption";
        public int PowerStatus
        {
            get;set;
        }
        public int currentTemperature;
        public int setTemperature;
        public int currentHumidity;
        public int setHumidity;

        public bool Power(int powerStatus)
        {
            bool power = true;
            power = (powerStatus == 1);
            return power;
        }



        public int SetTemperature(int currentTemperature, int setTemperature, int PowerStatus)
        {
            if (PowerStatus == 0) Console.WriteLine("Unavailable, power is not on!");
            else
            {
                if (currentTemperature >= setTemperature)
                {
                    PowerStatus = 0;
                    Power(PowerStatus);
                    Console.WriteLine("Temp reached, heating: " + Power(PowerStatus));
                }
                else
                {
                    PowerStatus = 1;
                    Power(PowerStatus);
                    Console.WriteLine("Temp not reached, heating: " + Power(PowerStatus));
                }
            }
            return 0;
        }

        public int SetHumidity(int currentHumidity, int setHumidity, int PowerStatus)
        {
            if (PowerStatus == 0) Console.WriteLine("Unavailable, power is not on!");
            else
            {
                if (currentHumidity >= setHumidity)
                {
                    PowerStatus = 0;
                    Power(PowerStatus);
                    Console.WriteLine("Humidity reached, humidity: " + Power(PowerStatus));
                }
                else
                {
                    PowerStatus = 1;
                    Power(PowerStatus);
                    Console.WriteLine("Humidity not reached, humidity: " + Power(PowerStatus));
                }
            }
            return 0;
        }
    }
}
