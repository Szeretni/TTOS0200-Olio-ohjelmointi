using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_06
{
    class Computer
    {
        //default constructor
        public Computer()
        {
            motherboard.Size = "Standard-ATX";
            processor.Manufacturer = "Intel";
            ram.Type = "DDR4";
        }

        //custom constructor
        public Computer(string mbSize, string proManu, string ramType)
        {
            motherboard.Size = mbSize;
            processor.Manufacturer = proManu;
            ram.Type = ramType;
        }

        //methods
        public void PrintInfo()
        {
            Console.WriteLine("Motherboard Size: {0}, Processor's Manufacturer: {1}, RAM Type: {2}",motherboard.Size,processor.Manufacturer,ram.Type);
        }
        public void SetInfo(string processorManufacturer)
        {
            processor.Manufacturer = processorManufacturer;
        }

        //composition components
        private Motherboard motherboard = new Motherboard();
        private Processor processor = new Processor();
        private RAM ram = new RAM();

        ~Computer()
        {
            Console.WriteLine("Computer recycled.");
        }
    }
}
