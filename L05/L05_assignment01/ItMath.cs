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
            string yearStr = "yy";
            int arraySize = (int)Math.Pow(2, 3);
            string[] formats = new string[arraySize];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arraySize;j++)
                {
                    switch(i)
                    {
                        case 0:
                            {
                                if (j < arraySize / 2)
                                {
                                    formats[j] = formats[j] + dateStr;
                                }
                                else
                                {
                                    for (int k = 0; k < 2; k++)
                                    {
                                        formats[j] = formats[j] + dateStr;
                                    }
                                }
                                break;
                            }
                        case 1:
                            {
                                if (j < arraySize / 2)
                                {
                                    formats[j] = formats[j] + "." + montStr;
                                }
                                else
                                {
                                    for (int k = 0; k < 2; k++)
                                    {
                                        if (k == 0) formats[j] = formats[j] + ".";
                                        formats[j] = formats[j] + montStr;
                                    }
                                }
                                break;
                            }
                        case 2:
                            {
                                if (j < arraySize / 2)
                                {
                                    formats[j] = formats[j] + "." + yearStr;
                                }
                                else
                                {
                                    for (int k = 0; k < 2; k++)
                                    {
                                        if (k == 0) formats[j] = formats[j] + ".";
                                        formats[j] = formats[j] + yearStr;
                                    }
                                }
                                break;
                            }
                    }
                }
            }
            /*int arrayIndex = 0;
            for (int i = 1; i < 3;i++ )
            {
                for (int j = 1; j < 3; j++)
                {
                    for (int k = 1; k < 3; k++)
                    {
                        formats[arrayIndex] = dateStr*i +
                        arrayIndex++;
                    }
                }
            }*/
            //string[] formats = { "d.M.yy", "d.MM.yy", "dd.M.yyyy", "d.M.yyyy", "dd.M.yy", "dd.MM.yy", "dd.MM.yy", "dd.MM.yyyy" };          
            DateTime boolDate = DateTime.Today;
            //input = input + " 0.0.0";
            bool result = DateTime.TryParseExact(input, formats, fi, DateTimeStyles.AllowLeadingWhite, out boolDate);
            return result;
        }
    }
}
