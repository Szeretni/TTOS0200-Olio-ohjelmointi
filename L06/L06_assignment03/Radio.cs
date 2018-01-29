using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment03
{
    class Radio
    {
        public void PowerSet()
        {
            Console.WriteLine("Set Power (0 = off, 1 = on): ");
            int input = int.Parse(Console.ReadLine());
            if (input == 0) Power = false;
            else Power = true;
            Console.WriteLine("Power is: " + Power);
        }
        public void VolumeSet()
        {
            Console.WriteLine("Set Volume ({0},...,{1}): ",volumeMin,volumeMax);
            int input = int.Parse(Console.ReadLine());
            Volume = input;
            Console.WriteLine("Volume is: " + Volume);
        }
        public void FrequencySet()
        {
            Console.WriteLine("Set Frequency ({0},...,{1}); ", frequencyMin, frequencyMax);
            double input = double.Parse(Console.ReadLine());
            Frequency = input;
            Console.WriteLine("Frequency is: " + Frequency);
        }
        public void PrintInfo()
        {
            Console.WriteLine("Current status:");
            Console.WriteLine("Power is: " + Power);
            Console.WriteLine("Volume is: " + Volume);
            Console.WriteLine("Frequency is: " + Frequency);
        }
        private bool Power { get; set; }
        private int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= volumeMin && value <= volumeMax) volume = value;
                else Console.WriteLine("User input is invalid");
            }
        }
        private double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value >= frequencyMin && value <= frequencyMax) frequency = value;
                else Console.WriteLine("User input is invalid");
            }
        }
        private bool power = false;
        private int volume;
        private int volumeMin = 0;
        private int volumeMax = 9;
        private double frequency;
        private double frequencyMin = 2000.0;
        private double frequencyMax = 26000.0;
    }
}
