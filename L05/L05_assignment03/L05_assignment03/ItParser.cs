using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_assignment03
{
    class ItParser
    {
        public static int Count(string input)
        {
            //1 because ie. 2 integers are separated by 1 dot
            int countDots = 1;
            foreach (char c in input)
            {
                if (c == ',') countDots++;
            }
            return countDots;
        }

        public static int Sum(string input)
        {
            int sum = 0;
            
            return 0;
        }

        public static int Average(string input)
        {
            return 0;
        }

        //private int count = 0;
        //private int sum = 0;
        //private int average = 0;
    }
}
