﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = StaticClass.Power2(15);
            Console.WriteLine("V: " + v);
        }
    }
}
