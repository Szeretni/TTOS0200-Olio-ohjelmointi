﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment_04
{
    class L06_04_Main
    {
        static void Main(string[] args)
        {
            MediaClass nightwish = new MediaClass();
            nightwish.Name = "Some Album";
            nightwish.Genre = "Rock?";

            DeviceClass laptop = new DeviceClass();
            laptop.Name = "Samsung";
            laptop.Type = "Laptop";
        }
    }
}