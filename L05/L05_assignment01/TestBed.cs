using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_assignment01
{
    class TestBed
    {
        public void TestBedFloat()
        {
            Console.Write("Give an input: ");
            string input = Console.ReadLine();
            Console.WriteLine(ItMath.NumberValidator(input));
        }

        public void TestBedDate()
        {
            Console.Write("Give an input: ");
            string input = Console.ReadLine();
            Console.WriteLine(ItMath.DateValidator(input));
        }
    }
}
