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
            string dotSrt = ".";
            int arraySize = (int)Math.Pow(2, 3);
            string[] formats = new string[arraySize];
            int tipCounterDefault = 0;

            //day-formatting
            int tipCounter = tipCounterDefault;
            bool flag = false;
            for (int i = 0; i < arraySize; i++)
            {
                int tipPoint = arraySize / (int)Math.Pow(2, 1);
                if (tipCounter == tipPoint)
                {
                    tipCounter = tipCounterDefault;
                    if (flag == false) flag = true;
                    else flag = false;
                }
                if (flag == false) formats[i] += dateStr + dotSrt;
                else formats[i] += dateStr + dateStr + dotSrt;
                tipCounter++;
            }
            
            //month-formatting
            tipCounter = tipCounterDefault;
            for (int i = 0; i < arraySize; i++)
            {
                int tipPoint = arraySize / (int)Math.Pow(2, 2);
                if (tipCounter == tipPoint)
                {
                    tipCounter = tipCounterDefault;
                    if (flag == false) flag = true;
                    else flag = false;
                }
                if (flag == false) formats[i] += montStr + dotSrt;
                else formats[i] += montStr + montStr + dotSrt;
                tipCounter++;
            }

            //year-formatting
            tipCounter = tipCounterDefault;
            for (int i = 0; i < arraySize; i++)
            {
                int tipPoint = arraySize / (int)Math.Pow(2, 3);
                if (tipCounter == tipPoint)
                {
                    tipCounter = tipCounterDefault;
                    if (flag == false) flag = true;
                    else flag = false;
                }
                if (flag == false) formats[i] += yearStr;
                else formats[i] += yearStr + yearStr;
                tipCounter++;
            }

            //to check that formats are correct
            //for (int i = 0; i < arraySize; i++) Console.WriteLine(formats[i]);

            DateTime boolDate = DateTime.Today;
            bool result = DateTime.TryParseExact(input, formats, fi, DateTimeStyles.AllowLeadingWhite, out boolDate);
            return result;
        }

        //Carbage...
        

        /*
        for (int i = 0; i < arraySize; i++)
        {
            bool flag = false;
            int tipPoint = arraySize / (int)Math.Pow(2, 1);
            if (i % tipPoint == 0)
            {
                if (flag == false) flag = true;
                else flag = false;
            }
            if (flag == false) formats[i] += dateStr + dotSrt;
            else formats[i] += dateStr + dateStr + dotSrt;
        }
        for (int i = 0; i < arraySize; i++)
        {
            bool flag = false;
            int tipPoint = arraySize / (int)Math.Pow(2, 2);
            if (i % tipPoint == 0)
            {
                if (flag == false) flag = true;
                else flag = false;
            }
            if (flag == false) formats[i] += montStr + dotSrt;
            else formats[i] += montStr + montStr + dotSrt;
        }
        for (int i = 0; i < arraySize; i++)
        {
            bool flag = false;
            int tipPoint = arraySize / (int)Math.Pow(2, 3);
            if (i % tipPoint == 0)
            {
                if (flag == false) flag = true;
                else flag = false;
            }
            if (flag == false) formats[i] += yearStr;
            else formats[i] += yearStr + yearStr;
        }
        */


        /*for (int i = 0; i < arraySize; i++)
        {
            if (i % 2 == 0) formats[i] += dateStr + dotSrt;
            else formats[i] += dateStr + dateStr + dotSrt;
        }
        for (int i = 0; i < arraySize; i++)
        {
            if (i % 2 == 0) formats[i] += montStr + dotSrt;
            else formats[i] += montStr + montStr + dotSrt;
        }
        for (int i = 0; i < arraySize; i++)
        {
            if (i % 2 == 0) formats[i] += yearStr;
            else formats[i] += yearStr + yearStr;
        }
        for (int i = 0; i < arraySize; i++) Console.WriteLine(formats[i]);
        */
        /*
        int ind = 0;
        for (int i = 0; i < 2; i++)
        {
            switch(i)
            {
                case 0:
                    formats[ind] = formats[ind] + dateStr + ".";
                    break;
                case 1:
                    formats[ind] = formats[ind] + dateStr + dateStr + ".";
                    break;
            }
            for (int j = 0; j< 2; j++)
            {
                switch (j)
                {
                    case 0:
                        formats[ind] = formats[ind] + montStr + ".";
                        break;
                    case 1:
                        formats[ind] = formats[ind] + montStr + montStr + ".";
                        break;
                }
                for (int k = 0; k < 2; k++)
                {
                    switch (k)
                    {
                        case 0:
                            formats[ind] = formats[ind] + yearStr;
                            break;
                        case 1:
                            formats[ind] = formats[ind] + yearStr + yearStr;
                            break;
                    }
                    ind++;
                }
            }
        }
        */
        /*
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
        */
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
    }
}
