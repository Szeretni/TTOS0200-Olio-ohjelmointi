using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_05
{
    class L12_05_Main
    {
        static void Main(string[] args)
        {
            double[] dArray = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine("Sum = {0:.00}",ArrayCalcs.Sum(dArray));
            Console.WriteLine("Ave = {0:.00}",ArrayCalcs.Average(dArray));
            Console.WriteLine("Min = {0:.00}",ArrayCalcs.Min(dArray));
            Console.WriteLine("Max = {0:.00}",ArrayCalcs.Max(dArray));
        }
    }
}

/*
Sum = 25,60
Ave = 3,66
Min = -4,50
Max = 12,00
Press any key to continue . . .
*/
/* array == null
Sum = ,00
Ave = epäluku
Jakso ei sisällä elementtejä Returned value 0
Min = ,00
Jakso ei sisällä elementtejä Returned value 0
Max = ,00
Press any key to continue . . .
*/
