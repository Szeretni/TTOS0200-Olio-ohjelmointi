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
            string dateStr = "d";
            string montStr = "M";
            string yeareStr = "y";

            //string[] formats = { "d.M.yy", "d.MM.yy", "dd.M.yyyy", "d.M.yyyy", "dd.M.yy", "dd.MM.yy", "dd.MM.yy", "dd.MM.yyyy" };          
            DateTime boolDate = DateTime.Today;
            //input = input + " 0.0.0";
            bool result = DateTime.TryParseExact(input, formats, fi, DateTimeStyles.AllowLeadingWhite, out boolDate);
            return result;
        }
    }
}
