using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_assignment01
{
    class ItMath
    {
        public static bool NumberValidator(string input)
        {
            float number;
            bool result = float.TryParse(input, out number);
            Console.Write("Input " + input + " is a number: ");
            return result;
        }

        public static bool DateValidator(string input)
        {
            CultureInfo fi = new CultureInfo("fi-FI");
            DateTime boolDate = new DateTime(2018,1,1);
            bool result = DateTime.TryParse(input,fi,DateTimeStyles.None,out boolDate);
            return result;
        }
    }
}
