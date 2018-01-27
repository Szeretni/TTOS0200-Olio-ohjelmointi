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
            //initialization
            int sum = 0;
            int strInt = 0;
            List<string> stringNum = new List<string>();
            string charString = "";

            //reading chars from input
            foreach (char c in input)
            {
                //add char to temp string
                if (c != ',')
                {
                    //charString = charString + c;
                    charString += c;
                }
                //add temp string to list and clear temp string
                if (c == ',')
                {
                    stringNum.Add(charString);
                    charString = "";
                }
            }

            //list strings to int, sum ints
            stringNum.Add(charString);
            foreach (string e in stringNum)
            {
                strInt = int.Parse(e);
                sum += strInt;
                strInt = 0;
            }
            return sum;
        }

        public static int Average(string input)
        {
            int elements = Count(input);
            int sum = Sum(input);
            int average = sum / elements;
            return average;
        }
    }
}
