using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_05
{
    public class ArrayCalcs
    {
        static public double Sum(double[] dArray)
        {
            double result = 0;
            foreach (double d in dArray)
            {
                result += d;
            }
            return result;
        }

        static public double Average(double[] dArray)
        {
            double result = Sum(dArray);
            int aLenght = dArray.Length;
            return result/aLenght;
        }

        static public double Min(double[] dArray)
        {
            try
            {
                double result = dArray.First();
                foreach (double d in dArray)
                {
                    if (d < result)
                    {
                        result = d;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Returned value 0");
                return 0;
            }
        }

        static public double Max(double[] dArray)
        {
            try
            {
                double result = dArray.First();
                foreach (double d in dArray)
                {
                    if (d > result)
                    {
                        result = d;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Returned value 0");
                return 0;
            }
        }
    }
}
