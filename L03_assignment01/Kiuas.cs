using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment01
{
    class Kiuas
    {
        public int CurrentTemperature
        {
            get
            {
                return currentTemperature;
            }
        }

        public int CurrentHumidity
        {
            get
            {
                return currentHumidity;
            }
        }

        public string KiuasInfo
        {
            get
            {
                return "\nMaterial: " + containerMaterial + ", stones: " + stoneMaterial + " and heating system: " + heatingSystemType
                    + "\nPower on: " + PowerStatus + ", current temperature: " + currentTemperature + " and current humidity: " + currentHumidity
                    + "\nDesired temperature: " + SetTemperature + " and desired humidity: " + SetHumidity
                    ;
            }
        }
        public bool PowerStatus
        {
            get;set;
        }

        public int SetTemperature
        {
            get
            {
                return setTemperature;
            }
                set
            {
                setTemperature = value;
            }
        }

        public int SetHumidity
        {
            get
            {
                return setHumidity;
            }
            set
            {
                setHumidity = value;
            }
        }

        public bool Power(int powerStatus)
        {
            bool power = true;
            power = (powerStatus == 1);
            return power;
        }

        private string containerMaterial = "Steel";
        private string stoneMaterial = "RandomStone";
        private string heatingSystemType = "Electrical";
        private int setTemperature = 50;
        private int setHumidity = 50;
        private int currentTemperature = 60;
        private int currentHumidity = 90;
        /*
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
        */
    }
}
