using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter integers and separate them by ','. Ie. 50,60,70,80,90.");
                Console.Write("Your input: ");
                string inputString = Console.ReadLine();

                //Count
                int count = ItParser.Count(inputString);

                //Sum
                int sum = ItParser.Sum(inputString);

                //Average
                int average = ItParser.Average(inputString);
                Console.WriteLine("Input " + inputString + " has " + count + " numbers, sum of the numbers is " + sum + " and average is (rounded down) "+ average + "\n");
            }
            
        }
    }
}
