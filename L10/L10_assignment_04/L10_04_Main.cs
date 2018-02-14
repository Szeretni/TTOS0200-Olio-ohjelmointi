using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L10_assignment_04
{
    class L10_04_Main
    {
        static void Main(string[] args)
        {
            try
            {
                //file stream
                //T2Integers.txt
                //T2Doubles
                StreamWriter outputInt = new StreamWriter("T2Integers.txt");
                StreamWriter outputDouble = new StreamWriter("T2Doubles.txt");

                //input validation
                while (true)
                {
                    //input manipulation
                    Console.Write("Give a number (enter or not a number ends) :");
                    string s = Console.ReadLine();
                    int resultInt;
                    double resultDouble;
                    bool isInt = int.TryParse(s, out resultInt);
                    bool isDouble = double.TryParse(s, out resultDouble);

                    //int, double or nn
                    if (isInt)
                    {
                        //Console.WriteLine("The number is an integer");
                        outputInt.WriteLine(resultInt);
                    }
                    else if (isDouble)
                    {
                        //Console.WriteLine("The number is a double");
                        outputDouble.WriteLine(resultDouble);
                    }
                    else
                    {
                        //Console.WriteLine("Not a valid input");
                        outputInt.Close();
                        outputDouble.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}